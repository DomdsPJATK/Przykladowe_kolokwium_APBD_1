using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using Przykladowe_kolokwium_APBD_1.DTOs.Request;
using Przykladowe_kolokwium_APBD_1.DTOs.Response;

namespace Przykladowe_kolokwium_APBD_1.Services
{
    public class SqlAnimalServiceDb : IServiceDb
    {
        private readonly string databaseURL = "Data Source=db-mssql;Initial Catalog=s19036;Integrated Security=True";

        public IActionResult getAnimals(string columnName)
        {   
            
            List<AnimalResponse> animalResponses = new List<AnimalResponse>();
            
            using (var client = new SqlConnection(databaseURL))
            using (var com = new SqlCommand())
            {
                com.Connection = client;
                client.Open();
                com.Transaction = client.BeginTransaction();

                try
                {
                    if (columnName == null) columnName = "AdmissionDate";
                    Console.WriteLine(columnName);
                    com.CommandText = $"SELECT Animal.Name, Animal.Type, Animal.AdmissionDate, Owner.FirstName  FROM Animal, Owner WHERE Animal.IdOwner = Owner.IdOwner ORDER BY {columnName}";
                    var db = com.ExecuteReader();
                    while (db.Read())
                    {
                         animalResponses.Add(new AnimalResponse()
                         {
                             Name = db["Name"].ToString(),
                             AnimalType = db["Type"].ToString(),
                             Date = DateTime.Parse(db["AdmissionDate"].ToString()),
                             LastNameOfOwner = db["FirstName"].ToString()
                         });
                    }
                    
                    return new OkObjectResult(animalResponses);

                }
                catch (SqlException e)
                {
                    com.Transaction.Rollback();
                    return new BadRequestResult();
                }
            }
        }

        public IActionResult enrollStudent(AnimalRequest animalRequest)
        {
            throw new System.NotImplementedException();
        }
        
    }
    
}