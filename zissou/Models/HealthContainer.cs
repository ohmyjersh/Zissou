using System;
using System.Collections.Generic;

namespace zissou.Models
{
    public static class HealthContainer
    {
        public static Dictionary<string, bool> Applications;
        static HealthContainer()
        {
            Applications = new Dictionary<string, bool>();
        }

   //     public static Dictionary<string, bool> GetApplicationStatusForApplications(List<Dependency> dependencies) {
   //         var copyDict = new Dictionary<string, bool>(Applications);
			//var filter = Applications. .Where(p => !dependencies.Contains(p.Key))
        //    	.ToDictionary(p => p.Key, p => p.Value);
        //}

        public static Dictionary<string, bool> GetStatus() {
            return Applications;
        }

        public static void SetStatus(string key, bool value)
        {
            AddOrUpdate(key, value);
        }

        public static void RemoveStatus(string key) {
            Applications.Remove(key);
        }

		private static void AddOrUpdate(string key, bool value)
		{
			if (Applications.ContainsKey(key))
			{
				Applications[key] = value;
			}
			else
			{
				Applications.Add(key, value);
			}
		}
    }
}
