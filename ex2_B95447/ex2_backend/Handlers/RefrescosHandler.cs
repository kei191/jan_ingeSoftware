using Microsoft.AspNetCore.Mvc;

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

  }
}
