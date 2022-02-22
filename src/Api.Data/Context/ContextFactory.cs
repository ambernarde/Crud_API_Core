using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migra��es
            var connectionString = "Server=localhost;Port=3306;Database=dbAPI2;Uid=root;Pwd=mudar@123";
            //var connectionString = "Server=.\\SQLEXPRESS2019;Initial Catalog=dbAPI;MultipleActiveResultSets=true;User ID=sa;Password=mudar@123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            //optionsBuilder.UseSqlServer(connectionString);
            return new MyContext(optionsBuilder.Options);

        }
    }

}