<Query Kind="Statements">
  <Connection>
    <ID>f43d3039-d441-4d0d-8e9f-dc47d84cf338</ID>
    <Persist>true</Persist>
    <Server>.\SQLEXPRESS</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

var  results = from g in Genres
              orderby g.Name
			  select new
			  {
			    Genres = g.Name,
				TracksCount=g.Tracks.Count()
			  };
results.Dump("Query Math 1 ");
			  