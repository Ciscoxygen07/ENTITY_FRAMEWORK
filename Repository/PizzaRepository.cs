using ENTITY_FRAMEWORK.Models;


using Microsoft.EntityFrameworkCore;

public class PizzaRepository : IPizzaRepository
{
    private readonly Context _context;

    public PizzaRepository(Context context)
    {
        _context = context;
    }
  
   public Pizza AddPizza(Pizza pizz) //object holding 1
   {
     _context.Pizzas.Add(pizz);
      _context.SaveChanges();
     return pizz;
    
   }

   public void DeletePizza(int id)
   {
     
       Pizza? result =  _context.Pizzas.FirstOrDefault(x => x.Id == id);
       _context.SaveChanges();
    _context.Pizzas.Remove(result);
       
   }

    public List <Pizza> GetAllPizza ()
   {
      List <Pizza> pizza = _context.Pizzas.ToList();
      return pizza;
   }

   public Pizza GetPizza(int id)
   {
       Pizza? result =  _context.Pizzas.FirstOrDefault(x => x.Id == id);
       return result; 
   }

   public Pizza UpdatePizza(Pizza pizz) //object holding 1
   {
       _context.Pizzas.Update(pizz);
        _context.SaveChanges();
        return pizz;
          
   }


}