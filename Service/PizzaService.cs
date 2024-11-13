using ENTITY_FRAMEWORK.Models;


public class PizzaService : IPizzaService
{
    private readonly IPizzaRepository _repository;

     public  PizzaService(IPizzaRepository repository)
    {
      _repository = repository;
    }


   public void DeleteNewPizza(int id)
    {
       Pizza pi = _repository.GetPizza(id);
        _repository.DeletePizza(pi.Id);
    }
   


   public  Pizza AddNewPizza(PizzaRequestModel requestModel)
    {   
        Pizza pi = new  Pizza();
        pi.Name = requestModel.Name;
        pi.Description = requestModel.Description;
        pi.IsAvailable = requestModel.IsAvailable;
        return  _repository.AddPizza(pi); // a class that talks to the database
        // return pi;
    }

    public Pizza UpdatePizza(Pizza model)
    {
       // Pizza pi = _repository.GetPizza(model.Id);
       Pizza pi =  _repository.UpdatePizza(model);
       return pi;
    }

    public List<Pizza> GetAllPizza()
    {
      return _repository.GetAllPizza();
    }
    
    public Pizza GetPizza(int id) 
    {
        Pizza pi = _repository.GetPizza(id);
        return pi;
    }

  
}