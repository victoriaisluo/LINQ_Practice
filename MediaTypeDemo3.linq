<Query Kind="Statements">
  <Connection>
    <ID>f43d3039-d441-4d0d-8e9f-dc47d84cf338</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var results = from m in MediaTypes
			 select new
			 {
			    Name=m.Name,
			   Tracks=from t in m.Tracks
				        select new 
				{
		             TracksName=t.Name,
					 Album=t.Album.Title,
					 Artist=t.Album.Artist.Name,
					 ReleaseYear=t.Album.ReleaseYear  ,
					 ReleaseLabel= t.Album.ReleaseLabel ,
					 Gener=t.Genre
				}
			 };
results.Dump();




