using System;
using TesteUDS.DAO;
using TesteUDS.Models;

namespace TesteUDS.Manager
{
    public class CreatePizzaManager
    {
        public static CreatePizzaManager Build()
        {
            return new CreatePizzaManager();
        }

        public mOrder AmountAndPrepared(int IdSize, int IdPizza)
        {
            mOrder Model = mOrder.Build();

            mSize Size = DaoSize.Build().GetId(IdSize);
            if (Size != null)
            {
                Model.Time = Size.Time;
                Model.Amount = Size.Amount;
                Model.IdSize = Size.Id;
                Model.mSize = Size;
            }
            else
            {
                Model.State.IsError = true;
                Model.State.MessageError = "Id do tamanho não esta cadastro no sistema";
                return Model;
            }

            mPizza Pizza = DaoPizza.Build().GetId(IdPizza);
            if (Pizza != null)
            {
                Model.Time = Model.Time + Pizza.Time;
                Model.Amount = Model.Amount + Pizza.Amount;
                Model.IdPizza = Pizza.Id;
                Model.mPizza = Pizza;
            }
            else
            {
                Model.State.IsError = true;
                Model.State.MessageError = "Id do pizza não esta cadastro no sistema";
                return Model;
            }

            DaoOrder.Build().Insert(Model);

            TimeSpan interval = TimeSpan.FromSeconds(Model.Time);
            Model.State.MessageSucess = string.Format("Confirme seu pedido Uma Pizza do sabor {0} do Tamanho {1}, no valor {2} e com tempo de preparo {3}:{4}",
                                        Model.mPizza.Description, Model.mSize.Description, Model.Amount, (int)interval.TotalHours, interval.Minutes);

            return Model;
        }
    }
}