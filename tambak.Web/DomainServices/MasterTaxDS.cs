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
    public class MasterTaxDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'MasterTaxes' query.
        [Query(IsDefault = true)]
        public IQueryable<MasterTax> GetMasterTaxes()
        {
            return this.ObjectContext.MasterTaxes;
        }

        public void InsertMasterTax(MasterTax masterTax)
        {
            if ((masterTax.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(masterTax, EntityState.Added);
            }
            else
            {
                this.ObjectContext.MasterTaxes.AddObject(masterTax);
            }
        }

        public void UpdateMasterTax(MasterTax currentMasterTax)
        {
            this.ObjectContext.MasterTaxes.AttachAsModified(currentMasterTax, this.ChangeSet.GetOriginal(currentMasterTax));
        }

        public void DeleteMasterTax(MasterTax masterTax)
        {
            if ((masterTax.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(masterTax, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.MasterTaxes.Attach(masterTax);
                this.ObjectContext.MasterTaxes.DeleteObject(masterTax);
            }
        }
    }
}


