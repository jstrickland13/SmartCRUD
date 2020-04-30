using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System;
using System.IO;
using WNCCRM;

namespace SmartCRUD
{


    class Program
    {
        private static string ASPNETCORE_ENVIRONMENT { get; } = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

        //We need the config early to setup serilog to capture errors at website startup.
        public static IConfiguration Configuration { get; } = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddJsonFile($"appsettings.{Program.ASPNETCORE_ENVIRONMENT}.json", optional: true)
                    .AddEnvironmentVariables()
                    .Build();

        static void Main(string[] args)
        {
            var code = new ModelBuilder(Configuration["ConnectionStrings:wincare"]).BuildOwner("WNCCRM");
            File.WriteAllLines("wnccrm.cs", code);

            using (var wincare = new OracleConnection(Configuration["ConnectionStrings:wincare"]))
            {
                var crud = new SmartCRUD<APPLICATION_CONFIG>();
                var key = new { APPL = "WNCCRM_MS", PARAM = "SECRET.1" };
                var sql = crud.BuildSelect(key);

                var list = wincare.Query(sql, key);
            }

            Console.Write("Press Enter");
            Console.ReadLine();
        }
    }
}
