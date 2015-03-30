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
    public class TasksDS : LinqToEntitiesDomainService<Entities>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'Tasks' query.
        [Query(IsDefault = true)]
        public IQueryable<Task> GetTasks()
        {
            return this.ObjectContext.Tasks;
        }

        public void InsertTask(Task task)
        {
            if ((task.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(task, EntityState.Added);
            }
            else
            {
                this.ObjectContext.Tasks.AddObject(task);
            }
        }

        public void UpdateTask(Task currentTask)
        {
            this.ObjectContext.Tasks.AttachAsModified(currentTask, this.ChangeSet.GetOriginal(currentTask));
        }

        public void DeleteTask(Task task)
        {
            if ((task.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(task, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.Tasks.Attach(task);
                this.ObjectContext.Tasks.DeleteObject(task);
            }
        }
    }
}


