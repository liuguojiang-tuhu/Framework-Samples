﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.0, CSLA Templates: v4.0.0.0, CSLA Framework: v4.3.10.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'LineItem.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
using System;

using Csla;
using Csla.Data;
using System.Data.SqlClient;
using Csla.Rules;

namespace PetShop.Tests.ParameterizedSQL
{
    [Serializable]
    public partial class LineItem : BusinessBase<LineItem>
    {
        #region Contructor(s)

        public LineItem()
        { /* Require use of factory methods */ }

        #endregion

        #region Business Rules

        /// <summary>
        /// Contains the CodeSmith generated validation rules.
        /// </summary>
        protected override void AddBusinessRules()
        {
            // Call the base class, if this call isn't made than any declared System.ComponentModel.DataAnnotations rules will not work.
            base.AddBusinessRules();

            if(AddBusinessValidationRules())
                return;

            BusinessRules.AddRule(new Csla.Rules.CommonRules.Required(_itemIdProperty));
            BusinessRules.AddRule(new Csla.Rules.CommonRules.MaxLength(_itemIdProperty, 10));
        }

        #endregion


        #region Properties

        private static readonly PropertyInfo<System.Int32> _orderIdProperty = RegisterProperty<System.Int32>(p => p.OrderId, "Order Id");
        [System.ComponentModel.DataObjectField(true, false)]
        public System.Int32 OrderId
        {
            get { return GetProperty(_orderIdProperty); }
            set{ SetProperty(_orderIdProperty, value); }
        }

        private static readonly PropertyInfo<System.Int32> _originalOrderIdProperty = RegisterProperty<System.Int32>(p => p.OriginalOrderId, "Original Order Id");
        /// <summary>
        /// Holds the original value for OrderId. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalOrderId
        {
            get { return GetProperty(_originalOrderIdProperty); }
            set{ SetProperty(_originalOrderIdProperty, value); }
        }

        private static readonly PropertyInfo<System.Int32> _lineNumProperty = RegisterProperty<System.Int32>(p => p.LineNum, "Line Num");
        [System.ComponentModel.DataObjectField(true, false)]
        public System.Int32 LineNum
        {
            get { return GetProperty(_lineNumProperty); }
            set{ SetProperty(_lineNumProperty, value); }
        }

        private static readonly PropertyInfo<System.Int32> _originalLineNumProperty = RegisterProperty<System.Int32>(p => p.OriginalLineNum, "Original Line Num");
        /// <summary>
        /// Holds the original value for LineNum. This is used for non identity primary keys.
        /// </summary>
        internal System.Int32 OriginalLineNum
        {
            get { return GetProperty(_originalLineNumProperty); }
            set{ SetProperty(_originalLineNumProperty, value); }
        }

        private static readonly PropertyInfo<System.String> _itemIdProperty = RegisterProperty<System.String>(p => p.ItemId, "Item Id");
        public System.String ItemId
        {
            get { return GetProperty(_itemIdProperty); }
            set{ SetProperty(_itemIdProperty, value); }
        }

        private static readonly PropertyInfo<System.Int32> _quantityProperty = RegisterProperty<System.Int32>(p => p.Quantity, "Quantity");
        public System.Int32 Quantity
        {
            get { return GetProperty(_quantityProperty); }
            set{ SetProperty(_quantityProperty, value); }
        }

        private static readonly PropertyInfo<System.Decimal> _unitPriceProperty = RegisterProperty<System.Decimal>(p => p.UnitPrice, "Unit Price");
        public System.Decimal UnitPrice
        {
            get { return GetProperty(_unitPriceProperty); }
            set{ SetProperty(_unitPriceProperty, value); }
        }

        // ManyToOne
        private static readonly PropertyInfo<Order> _orderProperty = RegisterProperty<Order>(p => p.Order, Csla.RelationshipTypes.Child);
        public Order Order
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_orderProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_orderProperty))
                    {
                        var criteria = new PetShop.Tests.ParameterizedSQL.OrderCriteria {OrderId = OrderId};
                        
                        if(PetShop.Tests.ParameterizedSQL.Order.Exists(criteria))
                            LoadProperty(_orderProperty, PetShop.Tests.ParameterizedSQL.Order.GetByOrderId(OrderId));
                    }
                }

                return GetProperty(_orderProperty); 
            }
        }


        #endregion

        #region Synchronous Root Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="LineItem"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="LineItem"/>.</returns>    
        public static LineItem NewLineItem()
        {
            return DataPortal.Create<LineItem>();
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <param name="lineNum">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>
        public static LineItem GetByOrderIdLineNum(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            
            
            return DataPortal.Fetch<LineItem>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>
        public static LineItem GetByOrderId(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            
            
            return DataPortal.Fetch<LineItem>(criteria);
        }

        public static void DeleteLineItem(System.Int32 orderId, System.Int32 lineNum)
        {
                DataPortal.Delete<LineItem>(new LineItemCriteria (orderId, lineNum));
        }

        #endregion

        #region Asynchronous Root Factory Methods
        
        public static void NewLineItemAsync(EventHandler<DataPortalResult<LineItem>> handler)
        {
            var dp = new DataPortal<LineItem>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        public static void GetByOrderIdLineNumAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            

            var dp = new DataPortal<LineItem>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void GetByOrderIdAsync(System.Int32 orderId, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId};
            

            var dp = new DataPortal<LineItem>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        public static void DeleteLineItemAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{OrderId = orderId, LineNum = lineNum};
            

            var dp = new DataPortal<LineItem>();
            dp.DeleteCompleted += handler;
            dp.BeginDelete(criteria);
        }
        
        #endregion

        #region Synchronous Child Factory Methods 

        /// <summary>
        /// Creates a new object of type <see cref="LineItem"/>. 
        /// </summary>
        /// <returns>Returns a newly instantiated collection of type <see cref="LineItem"/>.</returns>
        internal static LineItem NewLineItemChild()
        {
            return DataPortal.CreateChild<LineItem>();
        }

        internal static LineItem GetLineItem(SafeDataReader reader)
        {
            return DataPortal.FetchChild<LineItem>(reader);
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <param name="lineNum">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>

        internal static LineItem GetByOrderIdLineNumChild(System.Int32 orderId, System.Int32 lineNum)
        {
            var criteria = new LineItemCriteria {OrderId = orderId, LineNum = lineNum};
            

            return DataPortal.FetchChild<LineItem>(criteria);
        }

        /// <summary>
        /// Returns a <see cref="LineItem"/> object of the specified criteria. 
        /// </summary>
        /// <param name="orderId">No additional detail available.</param>
        /// <returns>A <see cref="LineItem"/> object of the specified criteria.</returns>

        internal static LineItem GetByOrderIdChild(System.Int32 orderId)
        {
            var criteria = new LineItemCriteria {OrderId = orderId};
            

            return DataPortal.FetchChild<LineItem>(criteria);
        }

        #endregion

        #region Asynchronous Child Factory Methods
        
        internal static void NewLineItemChildAsync(EventHandler<DataPortalResult<LineItem>> handler)
        {
            DataPortal<LineItem> dp = new DataPortal<LineItem>();
            dp.CreateCompleted += handler;
            dp.BeginCreate();
        }

        internal static void GetByOrderIdLineNumChildAsync(System.Int32 orderId, System.Int32 lineNum, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{ OrderId = orderId, LineNum = lineNum};
            
            
            // Mark as child?
            var dp = new DataPortal<LineItem>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        internal static void GetByOrderIdChildAsync(System.Int32 orderId, EventHandler<DataPortalResult<LineItem>> handler)
        {
            var criteria = new LineItemCriteria{ OrderId = orderId};
            
            
            // Mark as child?
            var dp = new DataPortal<LineItem>();
            dp.FetchCompleted += handler;
            dp.BeginFetch(criteria);
        }

        #endregion

        #region DataPortal partial methods

        /// <summary>
        /// CodeSmith generated stub method that is called when creating the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been created. 
        /// </summary>
        partial void OnCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnFetching(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been fetched. 
        /// </summary>    
        partial void OnFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(ref bool cancel);
 
        /// <summary>
        /// CodeSmith generated stub method that is called when mapping the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object mapping should proceed.</param>
        partial void OnMapping(SafeDataReader reader, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been mapped. 
        /// </summary>
        partial void OnMapped();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been inserted. 
        /// </summary>
        partial void OnInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been updated. 
        /// </summary>
        partial void OnUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object has been deleted. 
        /// </summary>
        partial void OnSelfDeleted();

        /// <summary>
        /// CodeSmith generated stub method that is called when deleting the <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containing the criteria of the object to delete.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object deletion should proceed.</param>
        partial void OnDeleting(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the <see cref="LineItem"/> object with the specified criteria has been deleted. 
        /// </summary>
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods


        /// <summary>
        /// CodeSmith generated stub method that is called when creating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildCreating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been created. 
        /// </summary>
        partial void OnChildCreated();

        /// <summary>
        /// CodeSmith generated stub method that is called when fetching the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="criteria"><see cref="LineItemCriteria"/> object containing the criteria of the object to fetch.</param>
        /// <param name="cancel">Value returned from the method indicating whether the object fetching should proceed.</param>
        partial void OnChildFetching(LineItemCriteria criteria, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been fetched. 
        /// </summary>
        partial void OnChildFetched();

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object insertion should proceed.</param>
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when inserting the child <see cref="LineItem"/> object. 
        /// </summary>
        partial void OnChildInserting(Order order, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been inserted. 
        /// </summary>
        partial void OnChildInserted();

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="cancel">Value returned from the method indicating whether the object creation should proceed.</param>
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called when updating the child <see cref="LineItem"/> object. 
        /// </summary>
        partial void OnChildUpdating(Order order, SqlConnection connection, ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been updated. 
        /// </summary>
        partial void OnChildUpdated();

        /// <summary>
        /// CodeSmith generated stub method that is called when self deleting the child <see cref="LineItem"/> object. 
        /// </summary>
        /// <param name="cancel">Value returned from the method indicating whether the object self deletion should proceed.</param>
        partial void OnChildSelfDeleting(ref bool cancel);

        /// <summary>
        /// CodeSmith generated stub method that is called after the child <see cref="LineItem"/> object has been deleted. 
        /// </summary>
        partial void OnChildSelfDeleted();
        #endregion


        #region Exists Command

        /// <summary>
        /// Determines if a record exists in the LineItem table in the database for the specified criteria. 
        /// </summary>
        /// <param name="criteria">The criteria parameter is an <see cref="LineItem"/> object.</param>
        /// <returns>A boolean value of true is returned if a record is found.</returns>
        public static bool Exists(LineItemCriteria criteria)
        {
            return PetShop.Tests.ParameterizedSQL.ExistsCommand.Execute(criteria);
        }

        /// <summary>
        /// Determines if a record exists in the LineItem table in the database for the specified criteria. 
        /// </summary>
        public static void ExistsAsync(LineItemCriteria criteria, EventHandler<DataPortalResult<ExistsCommand>> handler)
        {
            PetShop.Tests.ParameterizedSQL.ExistsCommand.ExecuteAsync(criteria, handler);
        }

        #endregion

    }
}