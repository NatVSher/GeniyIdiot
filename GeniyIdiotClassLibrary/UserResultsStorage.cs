﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary
{
    public class UserResultsStorage
    {
        public static string Path = "StatisticsGeniy_Idiot.json";

        public static void Append(User user)
        {
            var userResults = GetAll();
            userResults.Add(user);
            Save(userResults);
        }

        public static List<User> GetAll()
        {
            if (!File.Exists(Path))
            {
                return new List<User>();
            }
            var fileData = FileProvider.Get(Path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return userResults;            
        }
        static void Save(List<User> userResults)
        {
            var jsonData = JsonConvert.SerializeObject(userResults, Formatting.Indented);
            FileProvider.Replase(Path, jsonData);
        }
    }
}
