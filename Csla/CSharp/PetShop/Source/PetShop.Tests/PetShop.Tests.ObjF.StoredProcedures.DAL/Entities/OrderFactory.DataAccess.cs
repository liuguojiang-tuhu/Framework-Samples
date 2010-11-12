﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Order.cs'.
//
//     Template: ObjectFactory.DataAccess.StoredProcedures.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;
using System.Data;
using System.Data.SqlClient;

using Csla;
using Csla.Data;
using Csla.Server;

using PetShop.Tests.ObjF.StoredProcedures;

#endregion

namespace PetShop.Tests.ObjF.StoredProcedures.DAL
{
    public partial class OrderFactory : ObjectFactory
    {
        #region Create

        /// <summary>
        /// Creates new Order with default values.
        /// </summary>
        /// <returns>new Order.</returns>
        [RunLocal]
        public Order Create()
        {
            var item = (Order)Activator.CreateInstance(typeof(Order), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            using (BypassPropertyChecks(item))
            {
                // Default values.
            }

            CheckRules(item);
            MarkNew(item);
            OnCreated();

            return item;
        }

        /// <summary>
        /// Creates new Order with default values.
        /// </summary>
        /// <returns>new Order.</returns>
        [RunLocal]
        private Order Create(OrderCriteria criteria)
        {
            var item = (Order)Activator.CreateInstance(typeof(Order), true);

            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return item;

            var resource = Fetch(criteria);
            using (BypassPropertyChecks(item))
            {
                item.UserId = resource.UserId;
                item.OrderDate = resource.OrderDate;
                item.ShipAddr1 = resource.ShipAddr1;
                item.ShipAddr2 = resource.ShipAddr2;
                item.ShipCity = resource.ShipCity;
                item.ShipState = resource.ShipState;
                item.ShipZip = resource.ShipZip;
                item.ShipCountry = resource.ShipCountry;
                item.BillAddr1 = resource.BillAddr1;
                item.BillAddr2 = resource.BillAddr2;
                item.BillCity = resource.BillCity;
                item.BillState = resource.BillState;
                item.BillZip = resource.BillZip;
                item.BillCountry = resource.BillCountry;
                item.Courier = resource.Courier;
                item.TotalPrice = resource.TotalPrice;
                item.BillToFirstName = resource.BillToFirstName;
                item.BillToLastName = resource.BillToLastName;
                item.ShipToFirstName = resource.ShipToFirstName;
                item.ShipToLastName = resource.ShipToLastName;
                item.AuthorizationNumber = resource.AuthorizationNumber;
                item.Locale = resource.Locale;
            }

            CheckRules(item);
            MarkNew(item);

            OnCreated();

            return item;
        }

        #endregion

        #region Fetch

        /// <summary>
        /// Fetch Order.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <returns></returns>
        public Order Fetch(OrderCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return null;

            Order item;
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Order_Select]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    command.Parameters.AddWithValue("@p_ShipAddr2HasValue", criteria.ShipAddr2HasValue);
					command.Parameters.AddWithValue("@p_BillAddr2HasValue", criteria.BillAddr2HasValue);
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                           item = Map(reader);
                        else
                            throw new Exception(string.Format("The record was not found in 'Orders' using the following criteria: {0}.", criteria));
                    }
                }
            }

            MarkOld(item);
            OnFetched();
            return item;
        }

        #endregion

        #region Insert

        private void DoInsert(ref Order item, bool stopProccessingChildren)
        {
            // Don't update if the item isn't dirty.
            if (!item.IsDirty) return;

            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Order_Insert]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@p_OrderId", item.OrderId);
					command.Parameters["@p_OrderId"].Direction = ParameterDirection.Output;
					command.Parameters.AddWithValue("@p_UserId", item.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(item.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", item.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(item.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", item.BillCity);
					command.Parameters.AddWithValue("@p_BillState", item.BillState);
					command.Parameters.AddWithValue("@p_BillZip", item.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", item.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", item.Locale);

                    command.ExecuteNonQuery();

                    item.OrderId = (System.Int32)command.Parameters["@p_OrderId"].Value;
                }
            }


            MarkOld(item);
            CheckRules(item);
            
            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_LineItem_LineItems_OrderId(ref item);
                Update_OrderStatus_OrderStatuses_OrderId(ref item);
            }

            OnInserted();
        }

        #endregion

        #region Update

        [Transactional(TransactionalTypes.TransactionScope)]
        public Order Update(Order item)
        {
            return Update(item, false);
        }

        public Order Update(Order item, bool stopProccessingChildren)
        {
            if(item.IsDeleted)
            {
                DoDelete(ref item);
                MarkNew(item);
            }
            else if(item.IsNew)
            {
                DoInsert(ref item, stopProccessingChildren);
            }
            else
            {
                DoUpdate(ref item, stopProccessingChildren);
            }

            return item;
        }

        private void DoUpdate(ref Order item, bool stopProccessingChildren)
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            // Don't update if the item isn't dirty.
            if (item.IsDirty)
            {
                using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand("[dbo].[CSLA_Order_Update]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@p_OrderId", item.OrderId);
					command.Parameters["@p_OrderId"].Direction = ParameterDirection.Input;
					command.Parameters.AddWithValue("@p_UserId", item.UserId);
					command.Parameters.AddWithValue("@p_OrderDate", item.OrderDate);
					command.Parameters.AddWithValue("@p_ShipAddr1", item.ShipAddr1);
					command.Parameters.AddWithValue("@p_ShipAddr2", ADOHelper.NullCheck(item.ShipAddr2));
					command.Parameters.AddWithValue("@p_ShipCity", item.ShipCity);
					command.Parameters.AddWithValue("@p_ShipState", item.ShipState);
					command.Parameters.AddWithValue("@p_ShipZip", item.ShipZip);
					command.Parameters.AddWithValue("@p_ShipCountry", item.ShipCountry);
					command.Parameters.AddWithValue("@p_BillAddr1", item.BillAddr1);
					command.Parameters.AddWithValue("@p_BillAddr2", ADOHelper.NullCheck(item.BillAddr2));
					command.Parameters.AddWithValue("@p_BillCity", item.BillCity);
					command.Parameters.AddWithValue("@p_BillState", item.BillState);
					command.Parameters.AddWithValue("@p_BillZip", item.BillZip);
					command.Parameters.AddWithValue("@p_BillCountry", item.BillCountry);
					command.Parameters.AddWithValue("@p_Courier", item.Courier);
					command.Parameters.AddWithValue("@p_TotalPrice", item.TotalPrice);
					command.Parameters.AddWithValue("@p_BillToFirstName", item.BillToFirstName);
					command.Parameters.AddWithValue("@p_BillToLastName", item.BillToLastName);
					command.Parameters.AddWithValue("@p_ShipToFirstName", item.ShipToFirstName);
					command.Parameters.AddWithValue("@p_ShipToLastName", item.ShipToLastName);
					command.Parameters.AddWithValue("@p_AuthorizationNumber", item.AuthorizationNumber);
					command.Parameters.AddWithValue("@p_Locale", item.Locale);

                        //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                        int result = command.ExecuteNonQuery();
                        if (result == 0)
                            throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                        item.OrderId = (System.Int32)command.Parameters["@p_OrderId"].Value;
                    }
                }
            }


            MarkOld(item);
            CheckRules(item);

            if(!stopProccessingChildren)
            {
            // Update Child Items.
                Update_LineItem_LineItems_OrderId(ref item);
                Update_OrderStatus_OrderStatuses_OrderId(ref item);
            }

            OnUpdated();
        }

        #endregion

        #region Delete

        [Transactional(TransactionalTypes.TransactionScope)]
        public void Delete(OrderCriteria criteria)
        {
            //Note: this call to delete is for immediate deletion and doesn't keep track of any entity state.
            DoDelete(criteria);
        }

        protected void DoDelete(ref Order item)
        {
            // If we're not dirty then don't update the database.
            if (!item.IsDirty) return;

            // If we're new then don't call delete.
            if (item.IsNew) return;

            var criteria = new OrderCriteria{OrderId = item.OrderId};
            
            DoDelete(criteria);

            MarkNew(item);
        }

        /// <summary>
        /// This call to delete is for immediate deletion and doesn't keep track of any entity state.
        /// </summary>
        /// <param name="criteria">The Criteria.</param>
        private void DoDelete(OrderCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("[dbo].[CSLA_Order_Delete]", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        #endregion

        #region Helper Methods

        public Order Map(SafeDataReader reader)
        {
            var item = (Order)Activator.CreateInstance(typeof(Order), true);
            using (BypassPropertyChecks(item))
            {
                item.OrderId = reader.GetInt32("OrderId");
                item.UserId = reader.GetString("UserId");
                item.OrderDate = reader.GetDateTime("OrderDate");
                item.ShipAddr1 = reader.GetString("ShipAddr1");
                item.ShipAddr2 = reader.GetString("ShipAddr2");
                item.ShipCity = reader.GetString("ShipCity");
                item.ShipState = reader.GetString("ShipState");
                item.ShipZip = reader.GetString("ShipZip");
                item.ShipCountry = reader.GetString("ShipCountry");
                item.BillAddr1 = reader.GetString("BillAddr1");
                item.BillAddr2 = reader.GetString("BillAddr2");
                item.BillCity = reader.GetString("BillCity");
                item.BillState = reader.GetString("BillState");
                item.BillZip = reader.GetString("BillZip");
                item.BillCountry = reader.GetString("BillCountry");
                item.Courier = reader.GetString("Courier");
                item.TotalPrice = reader.GetDecimal("TotalPrice");
                item.BillToFirstName = reader.GetString("BillToFirstName");
                item.BillToLastName = reader.GetString("BillToLastName");
                item.ShipToFirstName = reader.GetString("ShipToFirstName");
                item.ShipToLastName = reader.GetString("ShipToLastName");
                item.AuthorizationNumber = reader.GetInt32("AuthorizationNumber");
                item.Locale = reader.GetString("Locale");
            }
            
            MarkOld(item);
            
            return item;
        }

        //AssociatedOneToMany
        private static void Update_LineItem_LineItems_OrderId(ref Order item)
        {
            foreach(LineItem itemToUpdate in item.LineItems)
            {
				itemToUpdate.OrderId = item.OrderId;

                new LineItemFactory().Update(itemToUpdate, true);
            }
        }
        //AssociatedOneToMany
        private static void Update_OrderStatus_OrderStatuses_OrderId(ref Order item)
        {
            foreach(OrderStatus itemToUpdate in item.OrderStatuses)
            {
				itemToUpdate.OrderId = item.OrderId;

                new OrderStatusFactory().Update(itemToUpdate, true);
            }
        }

        #endregion

        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(OrderCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(OrderCriteria criteria, ref bool cancel);
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion
    }
}