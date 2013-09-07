using System;
using Mono.Data.Sqlite;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace kinmokusei
{
	public class MyDatabaseClass
	{
		public string GetMyTable()
		{
			string db = "/Users/tomohiro/gitrepo/study/CSharp-Study/kinmokusei/database/mysqlite.db";
			bool exists = File.Exists (db);
			string returnData=String.Empty;
			if (exists) {
				using (var conn = new SqliteConnection ("Data Source=" + db)) {
					using (var cmd = conn.CreateCommand ()) {
						conn.Open ();
						cmd.CommandText = "SELECT * FROM mytable";
						using (var reader = cmd.ExecuteReader ()) {
							while (reader.Read ()) {
								ArrayList col = new ArrayList();
								for (int i = 1; i < reader.FieldCount; ++i) {
									col.Add(reader[i]);
								}
								returnData += String.Join(",", (string[])col.ToArray(typeof(String)));
							}
						}
					}
				}
			}
			return returnData;
		}
	}
}

