﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v5.2.3, CSLA Templates: v3.0.1.1934, CSLA Framework: v3.8.4.
//     Changes to this file will be lost after each regeneration.
//     To extend the functionality of this class, please modify the partial class 'Product.cs'.
//
//     Template: SwitchableObject.Generated.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using Csla;
using Csla.Validation;
using Csla.Data;
using System.Data.SqlClient;

#endregion

namespace PetShop.Business
{
    [Serializable]
    public partial class Product : BusinessBase< Product >
    {
        #region Contructor(s)

        private Product()
        { /* Require use of factory methods */ }

        internal Product(System.String productId)
        {
            using(BypassPropertyChecks)
            {
                LoadProperty(_productIdProperty, productId);
            }
        }

        internal Product(SafeDataReader reader)
        {
            Map(reader);
            MarkAsChild();  
        }
        #endregion

        #region Business Rules

        protected override void AddBusinessRules()
        {
            if(AddBusinessValidationRules())
                return;

            ValidationRules.AddRule(CommonRules.StringRequired, _productIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_productIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringRequired, _categoryIdProperty);
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_categoryIdProperty, 10));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_nameProperty, 80));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_descriptionProperty, 255));
            ValidationRules.AddRule(CommonRules.StringMaxLength, new CommonRules.MaxLengthRuleArgs(_imageProperty, 80));
        }

        #endregion

        #region Properties

        private static readonly PropertyInfo< System.String > _productIdProperty = RegisterProperty< System.String >(p => p.ProductId, string.Empty);
		[System.ComponentModel.DataObjectField(true, false)]
        public System.String ProductId
        {
            get { return GetProperty(_productIdProperty); }
            set{ SetProperty(_productIdProperty, value); }
        }

        private static readonly PropertyInfo< System.String > _originalProductIdProperty = RegisterProperty< System.String >(p => p.OriginalProductId, string.Empty);
        /// <summary>
        /// Holds the original value for ProductId. This is used for non identity primary keys.
        /// </summary>
        internal System.String OriginalProductId
        {
            get { return GetProperty(_originalProductIdProperty); }
            set{ SetProperty(_originalProductIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _categoryIdProperty = RegisterProperty< System.String >(p => p.CategoryId, string.Empty);
        public System.String CategoryId
        {
            get { return GetProperty(_categoryIdProperty); }
            set{ SetProperty(_categoryIdProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _nameProperty = RegisterProperty< System.String >(p => p.Name, string.Empty, (System.String)null);
        public System.String Name
        {
            get { return GetProperty(_nameProperty); }
            set{ SetProperty(_nameProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _descriptionProperty = RegisterProperty< System.String >(p => p.Description, string.Empty, (System.String)null);
        public System.String Description
        {
            get { return GetProperty(_descriptionProperty); }
            set{ SetProperty(_descriptionProperty, value); }
        }
        private static readonly PropertyInfo< System.String > _imageProperty = RegisterProperty< System.String >(p => p.Image, string.Empty, (System.String)null);
        public System.String Image
        {
            get { return GetProperty(_imageProperty); }
            set{ SetProperty(_imageProperty, value); }
        }
        //AssociatedManyToOne
        private static readonly PropertyInfo< Category > _categoryMemberProperty = RegisterProperty< Category >(p => p.CategoryMember, Csla.RelationshipTypes.Child);
        public Category CategoryMember
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_categoryMemberProperty, ref cancel);

                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_categoryMemberProperty))
                    {
                        var criteria = new PetShop.Business.CategoryCriteria {CategoryId = CategoryId};
                        
                        if(PetShop.Business.Category.Exists(criteria))
                            LoadProperty(_categoryMemberProperty, PetShop.Business.Category.GetByCategoryId(CategoryId));
                    }
                }

                return GetProperty(_categoryMemberProperty); 
            }
        }

        //AssociatedOneToMany
        private static readonly PropertyInfo< ItemList > _itemsProperty = RegisterProperty<ItemList>(p => p.Items, Csla.RelationshipTypes.Child);
        public ItemList Items
        {
            get
            {
                bool cancel = false;
                OnChildLoading(_itemsProperty, ref cancel);
    
                if (!cancel)
                {
                    if(!FieldManager.FieldExists(_itemsProperty))
                    {
                        var criteria = new PetShop.Business.ItemCriteria {ProductId = ProductId};
                        
    
                        if(!PetShop.Business.ItemList.Exists(criteria))
                            LoadProperty(_itemsProperty, PetShop.Business.ItemList.NewList());
                        else
                            LoadProperty(_itemsProperty, PetShop.Business.ItemList.GetByProductId(ProductId));
                    }
                }

                return GetProperty(_itemsProperty);
            }
        }


        #endregion

        #region Synchronous Root Factory Methods 
        
        public static Product NewProduct()
        {
            return DataPortal.Create< Product >();
        }

        public static Product GetByProductId(System.String productId)
        {
            var criteria = new ProductCriteria {ProductId = productId};
            
            
            return DataPortal.Fetch< Product >(criteria);
        }

        public static Product GetByName(System.String name)
        {
            var criteria = new ProductCriteria {Name = name};
            
            
            return DataPortal.Fetch< Product >(criteria);
        }

        public static Product GetByCategoryId(System.String categoryId)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId};
            
            
            return DataPortal.Fetch< Product >(criteria);
        }

        public static Product GetByCategoryIdName(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, Name = name};
            
            
            return DataPortal.Fetch< Product >(criteria);
        }

        public static Product GetByCategoryIdProductIdName(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name};
            
            
            return DataPortal.Fetch< Product >(criteria);
        }

        public static void DeleteProduct(System.String productId)
        {
                DataPortal.Delete(new ProductCriteria (productId));
        }
        
        #endregion

        #region Synchronous Child Factory Methods 
        
        internal static Product NewProductChild()
        {
            return DataPortal.CreateChild< Product >();
        }

        internal static Product GetByProductIdChild(System.String productId)
        {
            var criteria = new ProductCriteria {ProductId = productId};
            

            return DataPortal.FetchChild< Product >(criteria);
        }

        internal static Product GetByNameChild(System.String name)
        {
            var criteria = new ProductCriteria {Name = name};
            

            return DataPortal.FetchChild< Product >(criteria);
        }

        internal static Product GetByCategoryIdChild(System.String categoryId)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId};
            

            return DataPortal.FetchChild< Product >(criteria);
        }

        internal static Product GetByCategoryIdNameChild(System.String categoryId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, Name = name};
            

            return DataPortal.FetchChild< Product >(criteria);
        }

        internal static Product GetByCategoryIdProductIdNameChild(System.String categoryId, System.String productId, System.String name)
        {
            var criteria = new ProductCriteria {CategoryId = categoryId, ProductId = productId, Name = name};
            

            return DataPortal.FetchChild< Product >(criteria);
        }

        #endregion
        #region DataPortal partial methods

        partial void OnCreating(ref bool cancel);
        partial void OnCreated();
        partial void OnFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnFetched();
        partial void OnMapping(SafeDataReader reader, ref bool cancel);
        partial void OnMapped();
        partial void OnInserting(ref bool cancel);
        partial void OnInserted();
        partial void OnUpdating(ref bool cancel);
        partial void OnUpdated();
        partial void OnSelfDeleting(ref bool cancel);
        partial void OnSelfDeleted();
        partial void OnDeleting(ProductCriteria criteria, ref bool cancel);
        partial void OnDeleted();
        partial void OnChildLoading(Csla.Core.IPropertyInfo childProperty, ref bool cancel);

        #endregion

        #region ChildPortal partial methods

        partial void OnChildCreating(ref bool cancel);
        partial void OnChildCreated();
        partial void OnChildFetching(ProductCriteria criteria, ref bool cancel);
        partial void OnChildFetched();
        partial void OnChildInserting(SqlConnection connection, ref bool cancel);
        partial void OnChildInserted();
        partial void OnChildUpdating(SqlConnection connection, ref bool cancel);
        partial void OnChildUpdated();
        partial void OnChildSelfDeleting(ref bool cancel);
        partial void OnChildSelfDeleted();
        #endregion

        #region Exists Command

        public static bool Exists(ProductCriteria criteria)
        {
            return PetShop.Business.ExistsCommand.Execute(criteria);
        }

        #endregion

    }
}