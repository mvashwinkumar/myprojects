﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("LibraryModel", "FK_Tran_Books", "Books", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FinalizedProject.Book), "Tran", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FinalizedProject.Tran), true)]
[assembly: EdmRelationshipAttribute("LibraryModel", "FK_Tran_Members", "Members", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(FinalizedProject.Member), "Tran", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(FinalizedProject.Tran), true)]

#endregion

namespace FinalizedProject
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class LibraryEntities6 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new LibraryEntities6 object using the connection string found in the 'LibraryEntities6' section of the application configuration file.
        /// </summary>
        public LibraryEntities6() : base("name=LibraryEntities6", "LibraryEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryEntities6 object.
        /// </summary>
        public LibraryEntities6(string connectionString) : base(connectionString, "LibraryEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new LibraryEntities6 object.
        /// </summary>
        public LibraryEntities6(EntityConnection connection) : base(connection, "LibraryEntities6")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Member> Members
        {
            get
            {
                if ((_Members == null))
                {
                    _Members = base.CreateObjectSet<Member>("Members");
                }
                return _Members;
            }
        }
        private ObjectSet<Member> _Members;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Staff> Staffs
        {
            get
            {
                if ((_Staffs == null))
                {
                    _Staffs = base.CreateObjectSet<Staff>("Staffs");
                }
                return _Staffs;
            }
        }
        private ObjectSet<Staff> _Staffs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Tran> Trans
        {
            get
            {
                if ((_Trans == null))
                {
                    _Trans = base.CreateObjectSet<Tran>("Trans");
                }
                return _Trans;
            }
        }
        private ObjectSet<Tran> _Trans;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Members EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMembers(Member member)
        {
            base.AddObject("Members", member);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Staffs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToStaffs(Staff staff)
        {
            base.AddObject("Staffs", staff);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Trans EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTrans(Tran tran)
        {
            base.AddObject("Trans", tran);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="bookID">Initial value of the BookID property.</param>
        /// <param name="bookName">Initial value of the BookName property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="publisher">Initial value of the Publisher property.</param>
        /// <param name="totalStock">Initial value of the TotalStock property.</param>
        /// <param name="numberLended">Initial value of the NumberLended property.</param>
        /// <param name="location">Initial value of the Location property.</param>
        public static Book CreateBook(global::System.String bookID, global::System.String bookName, global::System.String author, global::System.String publisher, global::System.Int32 totalStock, global::System.Int32 numberLended, global::System.String location)
        {
            Book book = new Book();
            book.BookID = bookID;
            book.BookName = bookName;
            book.Author = author;
            book.Publisher = publisher;
            book.TotalStock = totalStock;
            book.NumberLended = numberLended;
            book.Location = location;
            return book;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                if (_BookID != value)
                {
                    OnBookIDChanging(value);
                    ReportPropertyChanging("BookID");
                    _BookID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("BookID");
                    OnBookIDChanged();
                }
            }
        }
        private global::System.String _BookID;
        partial void OnBookIDChanging(global::System.String value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookName
        {
            get
            {
                return _BookName;
            }
            set
            {
                OnBookNameChanging(value);
                ReportPropertyChanging("BookName");
                _BookName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BookName");
                OnBookNameChanged();
            }
        }
        private global::System.String _BookName;
        partial void OnBookNameChanging(global::System.String value);
        partial void OnBookNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                OnPublisherChanging(value);
                ReportPropertyChanging("Publisher");
                _Publisher = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Publisher");
                OnPublisherChanged();
            }
        }
        private global::System.String _Publisher;
        partial void OnPublisherChanging(global::System.String value);
        partial void OnPublisherChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Category
        {
            get
            {
                return _Category;
            }
            set
            {
                OnCategoryChanging(value);
                ReportPropertyChanging("Category");
                _Category = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Category");
                OnCategoryChanged();
            }
        }
        private global::System.String _Category;
        partial void OnCategoryChanging(global::System.String value);
        partial void OnCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 TotalStock
        {
            get
            {
                return _TotalStock;
            }
            set
            {
                OnTotalStockChanging(value);
                ReportPropertyChanging("TotalStock");
                _TotalStock = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalStock");
                OnTotalStockChanged();
            }
        }
        private global::System.Int32 _TotalStock;
        partial void OnTotalStockChanging(global::System.Int32 value);
        partial void OnTotalStockChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NumberLended
        {
            get
            {
                return _NumberLended;
            }
            set
            {
                OnNumberLendedChanging(value);
                ReportPropertyChanging("NumberLended");
                _NumberLended = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NumberLended");
                OnNumberLendedChanged();
            }
        }
        private global::System.Int32 _NumberLended;
        partial void OnNumberLendedChanging(global::System.Int32 value);
        partial void OnNumberLendedChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryModel", "FK_Tran_Books", "Tran")]
        public EntityCollection<Tran> Trans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tran>("LibraryModel.FK_Tran_Books", "Tran");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tran>("LibraryModel.FK_Tran_Books", "Tran", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryModel", Name="Member")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Member : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Member object.
        /// </summary>
        /// <param name="memberID">Initial value of the MemberID property.</param>
        /// <param name="memberName">Initial value of the MemberName property.</param>
        /// <param name="phoneNumber">Initial value of the PhoneNumber property.</param>
        /// <param name="address">Initial value of the Address property.</param>
        public static Member CreateMember(global::System.String memberID, global::System.String memberName, global::System.String phoneNumber, global::System.String address)
        {
            Member member = new Member();
            member.MemberID = memberID;
            member.MemberName = memberName;
            member.PhoneNumber = phoneNumber;
            member.Address = address;
            return member;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MemberID
        {
            get
            {
                return _MemberID;
            }
            set
            {
                if (_MemberID != value)
                {
                    OnMemberIDChanging(value);
                    ReportPropertyChanging("MemberID");
                    _MemberID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("MemberID");
                    OnMemberIDChanged();
                }
            }
        }
        private global::System.String _MemberID;
        partial void OnMemberIDChanging(global::System.String value);
        partial void OnMemberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MemberName
        {
            get
            {
                return _MemberName;
            }
            set
            {
                OnMemberNameChanging(value);
                ReportPropertyChanging("MemberName");
                _MemberName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MemberName");
                OnMemberNameChanged();
            }
        }
        private global::System.String _MemberName;
        partial void OnMemberNameChanging(global::System.String value);
        partial void OnMemberNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryModel", "FK_Tran_Members", "Tran")]
        public EntityCollection<Tran> Trans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Tran>("LibraryModel.FK_Tran_Members", "Tran");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Tran>("LibraryModel.FK_Tran_Members", "Tran", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryModel", Name="Staff")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Staff : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Staff object.
        /// </summary>
        /// <param name="staffID">Initial value of the StaffID property.</param>
        /// <param name="staffName">Initial value of the StaffName property.</param>
        /// <param name="staffPassword">Initial value of the StaffPassword property.</param>
        public static Staff CreateStaff(global::System.String staffID, global::System.String staffName, global::System.String staffPassword)
        {
            Staff staff = new Staff();
            staff.StaffID = staffID;
            staff.StaffName = staffName;
            staff.StaffPassword = staffPassword;
            return staff;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StaffID
        {
            get
            {
                return _StaffID;
            }
            set
            {
                if (_StaffID != value)
                {
                    OnStaffIDChanging(value);
                    ReportPropertyChanging("StaffID");
                    _StaffID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("StaffID");
                    OnStaffIDChanged();
                }
            }
        }
        private global::System.String _StaffID;
        partial void OnStaffIDChanging(global::System.String value);
        partial void OnStaffIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StaffName
        {
            get
            {
                return _StaffName;
            }
            set
            {
                OnStaffNameChanging(value);
                ReportPropertyChanging("StaffName");
                _StaffName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StaffName");
                OnStaffNameChanged();
            }
        }
        private global::System.String _StaffName;
        partial void OnStaffNameChanging(global::System.String value);
        partial void OnStaffNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String StaffPassword
        {
            get
            {
                return _StaffPassword;
            }
            set
            {
                OnStaffPasswordChanging(value);
                ReportPropertyChanging("StaffPassword");
                _StaffPassword = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("StaffPassword");
                OnStaffPasswordChanged();
            }
        }
        private global::System.String _StaffPassword;
        partial void OnStaffPasswordChanging(global::System.String value);
        partial void OnStaffPasswordChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LibraryModel", Name="Tran")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Tran : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Tran object.
        /// </summary>
        /// <param name="transactionID">Initial value of the TransactionID property.</param>
        /// <param name="bookID">Initial value of the BookID property.</param>
        /// <param name="memberID">Initial value of the MemberID property.</param>
        /// <param name="issueDate">Initial value of the IssueDate property.</param>
        /// <param name="dueDate">Initial value of the DueDate property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        public static Tran CreateTran(global::System.String transactionID, global::System.String bookID, global::System.String memberID, global::System.DateTime issueDate, global::System.DateTime dueDate, global::System.String status)
        {
            Tran tran = new Tran();
            tran.TransactionID = transactionID;
            tran.BookID = bookID;
            tran.MemberID = memberID;
            tran.IssueDate = issueDate;
            tran.DueDate = dueDate;
            tran.Status = status;
            return tran;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TransactionID
        {
            get
            {
                return _TransactionID;
            }
            set
            {
                if (_TransactionID != value)
                {
                    OnTransactionIDChanging(value);
                    ReportPropertyChanging("TransactionID");
                    _TransactionID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("TransactionID");
                    OnTransactionIDChanged();
                }
            }
        }
        private global::System.String _TransactionID;
        partial void OnTransactionIDChanging(global::System.String value);
        partial void OnTransactionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                OnBookIDChanging(value);
                ReportPropertyChanging("BookID");
                _BookID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("BookID");
                OnBookIDChanged();
            }
        }
        private global::System.String _BookID;
        partial void OnBookIDChanging(global::System.String value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String MemberID
        {
            get
            {
                return _MemberID;
            }
            set
            {
                OnMemberIDChanging(value);
                ReportPropertyChanging("MemberID");
                _MemberID = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("MemberID");
                OnMemberIDChanged();
            }
        }
        private global::System.String _MemberID;
        partial void OnMemberIDChanging(global::System.String value);
        partial void OnMemberIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime IssueDate
        {
            get
            {
                return _IssueDate;
            }
            set
            {
                OnIssueDateChanging(value);
                ReportPropertyChanging("IssueDate");
                _IssueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IssueDate");
                OnIssueDateChanged();
            }
        }
        private global::System.DateTime _IssueDate;
        partial void OnIssueDateChanging(global::System.DateTime value);
        partial void OnIssueDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                OnDueDateChanging(value);
                ReportPropertyChanging("DueDate");
                _DueDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DueDate");
                OnDueDateChanged();
            }
        }
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ReturnDate
        {
            get
            {
                return _ReturnDate;
            }
            set
            {
                OnReturnDateChanging(value);
                ReportPropertyChanging("ReturnDate");
                _ReturnDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ReturnDate");
                OnReturnDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _ReturnDate;
        partial void OnReturnDateChanging(Nullable<global::System.DateTime> value);
        partial void OnReturnDateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Remarks
        {
            get
            {
                return _Remarks;
            }
            set
            {
                OnRemarksChanging(value);
                ReportPropertyChanging("Remarks");
                _Remarks = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Remarks");
                OnRemarksChanged();
            }
        }
        private global::System.String _Remarks;
        partial void OnRemarksChanging(global::System.String value);
        partial void OnRemarksChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryModel", "FK_Tran_Books", "Books")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryModel.FK_Tran_Books", "Books").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryModel.FK_Tran_Books", "Books").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("LibraryModel.FK_Tran_Books", "Books");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("LibraryModel.FK_Tran_Books", "Books", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LibraryModel", "FK_Tran_Members", "Members")]
        public Member Member
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryModel.FK_Tran_Members", "Members").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryModel.FK_Tran_Members", "Members").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Member> MemberReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Member>("LibraryModel.FK_Tran_Members", "Members");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Member>("LibraryModel.FK_Tran_Members", "Members", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
