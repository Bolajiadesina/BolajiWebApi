using System;
using System.Collections.Generic;
using System.Text.Json;
namespace Countries;

public class CountriesList
{

        public static string  GetCountriesList(){
        string jsonString = @"
        [
            {""CountryName"":""United States"",""Continent"":""North America"",""CountryCode"":""US""},
            {""CountryName"":""Canada"",""Continent"":""North America"",""CountryCode"":""CA""},
            {""CountryName"":""Brazil"",""Continent"":""South America"",""CountryCode"":""BR""},
            {""CountryName"":""Germany"",""Continent"":""Europe"",""CountryCode"":""DE""},
            {""CountryName"":""China"",""Continent"":""Asia"",""CountryCode"":""CN""},
            {""CountryName"":""Australia"",""Continent"":""Oceania"",""CountryCode"":""AU""},
            {""CountryName"":""Nigeria"",""Continent"":""Africa"",""CountryCode"":""NG""}
        ]";

        
        return jsonString;


        }



}
