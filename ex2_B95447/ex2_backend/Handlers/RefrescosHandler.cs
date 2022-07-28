using Microsoft.AspNetCore.Mvc;
using ex2_backend.Models;

namespace ex2_backend.Handlers
{
  public class RefrescosHandler
  {
    static List<string> nombre = new List<string>()
    {
      "Coca-Cola",
      "Pepsi",
      "Fanta",
      "Sprite"
    };

    static List<int> cantidad = new List<int>()
    {
      10,
      8,
      10,
      15
    };

    static List<int> precio = new List<int>()
    {
      500,
      600,
      550,
      725
    };

    public static List<RefrescosModel> GetRefrescos()
    {
      List<RefrescosModel> juguito = new List<RefrescosModel>();

      for (int i = 0; i < nombre.Count; i++)
      {
        juguito.Add(new RefrescosModel
        {
          nombre = nombre[i],
          cantidad = cantidad[i].ToString(),
          precio = precio[i].ToString()
        });
      }
      return juguito;
    }

  }
}
