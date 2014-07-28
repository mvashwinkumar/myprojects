/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.iss.basket.service;

import com.iss.basket.ajaxModels.CurrencyRate;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.math.BigDecimal;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.inject.Inject;
import javax.json.Json;
import javax.json.JsonArray;
import javax.json.JsonArrayBuilder;
import javax.json.JsonObject;
import javax.json.JsonObjectBuilder;
import javax.ws.rs.Consumes;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.container.AsyncResponse;
import javax.ws.rs.container.Suspended;

/**
 *
 * @author yc
 */
@Path("/Currency")
public class CurrencyService {

    @Inject
    private CurrencyThread asyncThread;

    @POST
    @Consumes("application/json")
    
    public void getCurrency(@Suspended final AsyncResponse ar, final JsonObject currencies) {

        asyncThread.getThreadPool().submit(new Runnable() {
            @Override
            public void run() {
                ArrayList<CurrencyRate> rates = new ArrayList<CurrencyRate>();
                JsonArray allCurrency = currencies.getJsonArray("currencies");

                for (int i = 0; i < allCurrency.size(); i++) {

                    try {
                        URL url = new URL("http://currency-api.appspot.com/api/SGD/" + allCurrency.get(i).toString() + ".json?key=79c52c6b9f5b342952b7df28c85c86bc17ede39f");
                        URLConnection connection = url.openConnection();
                        connection.setDoOutput(true);
                        connection.connect();
                        BufferedReader br = new BufferedReader(new InputStreamReader(connection.getInputStream()));
                        String result = br.readLine();
                        //close connection to remote url
                        connection.getInputStream().close();

                        CurrencyRate rate = new CurrencyRate();
                        rate.setCurrencyCode(allCurrency.get(i).toString());
                        rate.setRate(getRate(result));
                        rates.add(rate);
                        //return String.valueOf(getRate(result));

                    } catch (MalformedURLException ex) {
                        Logger.getLogger(CurrencyService.class.getName()).log(Level.SEVERE, null, ex);
                    } catch (IOException ex) {
                        Logger.getLogger(CurrencyService.class.getName()).log(Level.SEVERE, null, ex);
                    }
                }
                JsonArrayBuilder currencyJson = Json.createArrayBuilder();
                
                for(CurrencyRate cr:rates)
                {
                    JsonObjectBuilder eachCurrency = Json.createObjectBuilder();
                    eachCurrency.add("currencyCode", cr.getCurrencyCode());
                    eachCurrency.add("rate", cr.getRate());
                    currencyJson.add(eachCurrency);
                }               
                
                ar.resume(currencyJson.build());
            }
        });

    }

    public double getRate(String jsonStr) {
        String[] tokens = jsonStr.split(",");
        for (String s : tokens) {
            if (s.indexOf("rate") > 0) {
                //rate exists
                double rate = Double.valueOf(s.replaceAll(" \"rate\": ", "")).doubleValue();
                return rate;
            }
        }
        return -1;
    }

}
