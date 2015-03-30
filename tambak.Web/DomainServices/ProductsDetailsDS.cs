﻿
namespace tambak.Web.DomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using tambak.Web;


    // Implements application logic using the Entities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class ProductsDetailsDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ProductsDetails' query.
        [Query(IsDefault = true)]
        public IQueryable<ProductsDetail> GetProductsDetails()
        {
            return this.ObjectContext.ProductsDetails;
        }

        public void InsertProductsDetail(ProductsDetail productsDetail)
        {
            if ((productsDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productsDetail, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ProductsDetails.AddObject(productsDetail);
            }
        }

        public void UpdateProductsDetail(ProductsDetail currentProductsDetail)
        {
            this.ObjectContext.ProductsDetails.AttachAsModified(currentProductsDetail, this.ChangeSet.GetOriginal(currentProductsDetail));
        }

        public void DeleteProductsDetail(ProductsDetail productsDetail)
        {
            if ((productsDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(productsDetail, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ProductsDetails.Attach(productsDetail);
                this.ObjectContext.ProductsDetails.DeleteObject(productsDetail);
            }
        }
    }
}


