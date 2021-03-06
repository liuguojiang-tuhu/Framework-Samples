﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.5.3, CSLA Templates: v4.0.0.0, CSLA Framework: v4.5.x.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Item.cs'.
//
//     Template: SwitchableObject.DataAccess.ParameterizedSQL.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#if !SILVERLIGHT && !NETFX_CORE
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using Csla;
using Csla.Data;

namespace PetShop.Business
{
    public partial class Item
    {
        #region Root Data Access

        [RunLocal]
        protected override void DataPortal_Create()
        {
            bool cancel = false;
            OnCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnCreated();
        }

        private void DataPortal_Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if (reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Item' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnFetched();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Insert()
        {
            bool cancel = false;
            OnInserting(ref cancel);
            if (cancel) return;

            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalItemIdProperty, this.ItemId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnInserted();

        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected override void DataPortal_Update()
        {
            bool cancel = false;
            OnUpdating(ref cancel);
            if (cancel) return;

            if(OriginalItemId != ItemId)
            {
                // Insert new child.
                Item item = new Item {ItemId = ItemId, ProductId = ProductId, Status = Status, Name = Name, Image = Image};
                                if(ListPrice.HasValue) item.ListPrice = ListPrice.Value;
                if(UnitCost.HasValue) item.UnitCost = UnitCost.Value;
                if(Supplier.HasValue) item.Supplier = Supplier.Value;
                item = item.Save();

                // Mark editable child lists as dirty. This code may need to be updated to one-to-one relationships.

                // Create a new connection.
                using (var connection = new SqlConnection(ADOHelper.ConnectionString))
                {
                    connection.Open();
                    FieldManager.UpdateChildren(this, connection);
                }

                // Delete the old.
                var criteria = new ItemCriteria {ItemId = OriginalItemId};
                
                DataPortal_Delete(criteria);

                // Mark the original as the new one.
                OriginalItemId = ItemId;

                OnUpdated();

                return;
            }

            const string commandText = "UPDATE [dbo].[Item] SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId; SELECT [ItemId] FROM [dbo].[Item] WHERE [ItemId] = @p_OriginalItemId";
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using(var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddWithValue("@p_OriginalItemId", this.OriginalItemId);
                command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                    LoadProperty(_originalItemIdProperty, this.ItemId);
                }

                FieldManager.UpdateChildren(this, connection);
            }

            OnUpdated();
        }

        protected override void DataPortal_DeleteSelf()
        {
            bool cancel = false;
            OnSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ItemCriteria (ItemId));
        
            OnSelfDeleted();
        }

        [Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(ItemCriteria criteria)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                    //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                    int result = command.ExecuteNonQuery();
                    if (result == 0)
                        throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
                }
            }

            OnDeleted();
        }

        //[Transactional(TransactionalTypes.TransactionScope)]
        protected void DataPortal_Delete(ItemCriteria criteria, SqlConnection connection)
        {
            bool cancel = false;
            OnDeleting(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("DELETE FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");
            }

            OnDeleted();
        }

        #endregion

        #region Child Data Access

        protected override void Child_Create()
        {
            bool cancel = false;
            OnChildCreating(ref cancel);
            if (cancel) return;


            BusinessRules.CheckRules();

            OnChildCreated();
        }

        private void Child_Fetch(ItemCriteria criteria)
        {
            bool cancel = false;
            OnChildFetching(criteria, ref cancel);
            if (cancel) return;

            string commandText = String.Format("SELECT [ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image] FROM [dbo].[Item] {0}", ADOHelper.BuildWhereStatement(criteria.StateBag));
            using (var connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(criteria.StateBag));
                    using(var reader = new SafeDataReader(command.ExecuteReader()))
                    {
                        if(reader.Read())
                            Map(reader);
                        else
                            throw new Exception(String.Format("The record was not found in 'dbo.Item' using the following criteria: {0}.", criteria));
                    }
                }
            }

            OnChildFetched();


            MarkAsChild();
        }

        #region Child_Insert

        private void Child_Insert(SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update the original non-identity primary key value.
                LoadProperty(_originalItemIdProperty, this.ItemId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        private void Child_Insert(Product product, SqlConnection connection)
        {
            Child_Insert(product, null, connection);
        }


        private void Child_Insert(Supplier supplier, SqlConnection connection)
        {
            Child_Insert(null, supplier, connection);
        }


        private void Child_Insert(Product product, Supplier supplier, SqlConnection connection)
        {
            bool cancel = false;
            OnChildInserting(product, supplier, connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "INSERT INTO [dbo].[Item] ([ItemId], [ProductId], [ListPrice], [UnitCost], [Supplier], [Status], [Name], [Image]) VALUES (@p_ItemId, @p_ProductId, @p_ListPrice, @p_UnitCost, @p_Supplier, @p_Status, @p_Name, @p_Image)";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", product != null ? product.ProductId : this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(supplier != null ? supplier.SuppId : this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                //result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(product != null && product.ProductId != this.ProductId)
                    LoadProperty(_productIdProperty, product.ProductId);

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(supplier != null && supplier.SuppId != this.Supplier)
                    LoadProperty(_supplierProperty, supplier.SuppId);

                // Update the original non-identity primary key value.
                LoadProperty(_originalItemIdProperty, this.ItemId);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildInserted() and insert this child manually.
            // FieldManager.UpdateChildren(this, connection);

            OnChildInserted();
        }

        #endregion

        #region Child_Update

        private void Child_Update(SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Item] SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId; SELECT [ItemId] FROM [dbo].[Item] WHERE [ItemId] = @p_OriginalItemId";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalItemId", this.OriginalItemId);
                command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                // result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update non-identity primary key value.
                LoadProperty(_originalItemIdProperty, this.ItemId);
            }

            FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }

        private void Child_Update(Product product, SqlConnection connection)
        {
            Child_Update(product, null, connection);
        }


        private void Child_Update(Supplier supplier, SqlConnection connection)
        {
            Child_Update(null, supplier, connection);
        }

 
        private void Child_Update(Product product, Supplier supplier, SqlConnection connection)
        {
            bool cancel = false;
            OnChildUpdating(product, supplier, connection, ref cancel);
            if (cancel) return;

            if(connection.State != ConnectionState.Open) connection.Open();
            const string commandText = "UPDATE [dbo].[Item] SET [ItemId] = @p_ItemId, [ProductId] = @p_ProductId, [ListPrice] = @p_ListPrice, [UnitCost] = @p_UnitCost, [Supplier] = @p_Supplier, [Status] = @p_Status, [Name] = @p_Name, [Image] = @p_Image WHERE [ItemId] = @p_OriginalItemId; SELECT [ItemId] FROM [dbo].[Item] WHERE [ItemId] = @p_OriginalItemId";
            using(var command = new SqlCommand(commandText, connection))
            {
                command.Parameters.AddWithValue("@p_OriginalItemId", this.OriginalItemId);
                command.Parameters.AddWithValue("@p_ItemId", this.ItemId);
                command.Parameters.AddWithValue("@p_ProductId", product != null ? product.ProductId : this.ProductId);
                command.Parameters.AddWithValue("@p_ListPrice", ADOHelper.NullCheck(this.ListPrice));
                command.Parameters.AddWithValue("@p_UnitCost", ADOHelper.NullCheck(this.UnitCost));
                command.Parameters.AddWithValue("@p_Supplier", ADOHelper.NullCheck(supplier != null ? supplier.SuppId : this.Supplier));
                command.Parameters.AddWithValue("@p_Status", ADOHelper.NullCheck(this.Status));
                command.Parameters.AddWithValue("@p_Name", ADOHelper.NullCheck(this.Name));
                command.Parameters.AddWithValue("@p_Image", ADOHelper.NullCheck(this.Image));

                // result: The number of rows changed, inserted, or deleted. -1 for select statements; 0 if no rows were affected, or the statement failed. 
                int result = command.ExecuteNonQuery();
                if (result == 0)
                    throw new DBConcurrencyException("The entity is out of date on the client. Please update the entity and try again. This could also be thrown if the sql statement failed to execute.");

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(product != null && product.ProductId != this.ProductId)
                    LoadProperty(_productIdProperty, product.ProductId);

                // Update foreign keys values. This code will update the values passed in from the parent only if no errors occurred after executing the query.
                if(supplier != null && supplier.SuppId != this.Supplier)
                    LoadProperty(_supplierProperty, supplier.SuppId);

                // Update non-identity primary key value.
                LoadProperty(_originalItemIdProperty, this.ItemId);
            }
            
            // A child relationship exists on this Business Object but its type is not a child type (E.G. EditableChild). 
            // TODO: Please override OnChildUpdated() and update this child manually.
            // FieldManager.UpdateChildren(this, connection);

            OnChildUpdated();
        }
        #endregion

        private void Child_DeleteSelf()
        {
            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;
            
            DataPortal_Delete(new ItemCriteria (ItemId));
        
            OnChildSelfDeleted();
        }

        private void Child_DeleteSelf(params object[] args)
        {
            var connection = args.OfType<SqlConnection>().FirstOrDefault();
            if(connection == null)
                throw new ArgumentNullException("args", "Must contain a SqlConnection parameter.");

            bool cancel = false;
            OnChildSelfDeleting(ref cancel);
            if (cancel) return;

            DataPortal_Delete(new ItemCriteria (ItemId), connection);

            OnChildSelfDeleted();
        }

        #endregion

        #region Map

        private void Map(SafeDataReader reader)
        {
            bool cancel = false;
            OnMapping(reader, ref cancel);
            if (cancel) return;

            using(BypassPropertyChecks)
            {
                LoadProperty(_itemIdProperty, reader["ItemId"]);
                LoadProperty(_originalItemIdProperty, reader["ItemId"]);
                LoadProperty(_productIdProperty, reader["ProductId"]);
                LoadProperty(_listPriceProperty, reader["ListPrice"]);
                LoadProperty(_unitCostProperty, reader["UnitCost"]);
                LoadProperty(_supplierProperty, reader["Supplier"]);
                LoadProperty(_statusProperty, reader["Status"]);
                LoadProperty(_nameProperty, reader["Name"]);
                LoadProperty(_imageProperty, reader["Image"]);
            }

            OnMapped();
        }
        
        private void Child_Fetch(SafeDataReader reader)
        {
            Map(reader);
        }

        #endregion
    }
}
#endif