using MongoDB.Bson.Serialization.Attributes;

namespace DriversAppApi.Models;
public class Driver
{
  [BsonId]
  [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
  // meaning id is nullable
    public string? Id {get;set;}

    [BsonElement("Name")]
    public string DriverName{get;set;}=null!;
     public int Number{get;set;}
    public string Team{get;set;}=null!;
}