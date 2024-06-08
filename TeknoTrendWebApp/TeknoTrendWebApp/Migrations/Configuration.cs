namespace TeknoTrendWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeknoTrendWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeknoTrendWebApp.Models.TeknoTrendDBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TeknoTrendWebApp.Models.TeknoTrendDBModel context)
        {
            #region Manager Types

            //Oluşturulan tabloların eğer varsa başlangıç verilerini ekleme için kullandığımız alan
            context.ManagerTypes.AddOrUpdate(x => x.ID, new ManagerType() { ID = 1, Name = "Admin" });
            context.ManagerTypes.AddOrUpdate(x => x.ID, new ManagerType() { ID = 2, Name = "Moderatör" });

            #endregion

            #region Managers

            context.Managers.AddOrUpdate(x => x.ID, new Manager() { ID = 1, Name = "John", Surname = "Doe", Email = "johndoe26@hotmail.com", ManagerType_ID = 1, NickName = "j.doe", Password = "1234", IsActive = true, IsDeleted = false });


            #endregion

        }
    }
}
