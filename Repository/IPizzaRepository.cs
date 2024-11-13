using ENTITY_FRAMEWORK.Models;


using Microsoft.EntityFrameworkCore;

public interface IPizzaRepository
{
   void DeletePizza(int id); //interface method

   Pizza AddPizza(Pizza pizz);

   Pizza UpdatePizza(Pizza pizz);
    
   List<Pizza> GetAllPizza(); // we don't  need to get all by collecting parameters

   Pizza GetPizza(int id); //retrieve
}


