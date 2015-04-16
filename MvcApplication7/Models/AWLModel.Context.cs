﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication7.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class awlDbEntities : DbContext
    {
        public awlDbEntities()
            : base("name=awlDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<collector> collector { get; set; }
    
        public virtual ObjectResult<PROC_COLLECTOR_REQUEST_Result> PROC_COLLECTOR_REQUEST(string buildingId, string gatewayId)
        {
            var buildingIdParameter = buildingId != null ?
                new ObjectParameter("buildingId", buildingId) :
                new ObjectParameter("buildingId", typeof(string));
    
            var gatewayIdParameter = gatewayId != null ?
                new ObjectParameter("gatewayId", gatewayId) :
                new ObjectParameter("gatewayId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_COLLECTOR_REQUEST_Result>("PROC_COLLECTOR_REQUEST", buildingIdParameter, gatewayIdParameter);
        }
    }
}
