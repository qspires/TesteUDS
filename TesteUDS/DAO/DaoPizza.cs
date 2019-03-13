using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS.DAO
{
    public class DaoPizza
    {
        public static DaoPizza Build()
        {
            return new DaoPizza();
        }


        public List<mPizza> GetAll()
        {
            return EFContext.Build().mPizza.ToList();
        }

        public mPizza GetId(int Id)
        {
            return EFContext.Build().mPizza.Find(Id);
        }


        public mPizza Insert(mPizza mPizza)
        {
            try
            {
                var Context = EFContext.Build();

                Context.mPizza.Add(mPizza);
                Context.SaveChanges();

                mPizza.State.IsError = false;
                mPizza.State.MessageSucess = "Pizza Cadastra com Sucesso";
            }
            catch (Exception ex)
            {
                mPizza.State.IsError = true;
                mPizza.State.MessageError = ex.Message.ToString();
            }
            return mPizza;
        }

        public mPizza Update(mPizza mPizza)
        {
            try
            {
                var Context = EFContext.Build();

                mPizza Model = GetId(mPizza.Id);

                Context.Entry(Model.SetPizza(mPizza)).State = EntityState.Modified;
                Context.SaveChanges();

                mPizza.State.IsError = false;
                mPizza.State.MessageSucess = "Pizza Atualizada com Sucesso";
            }
            catch (Exception ex)
            {
                mPizza.State.IsError = true;
                mPizza.State.MessageError = ex.Message.ToString();
            }

            return mPizza;
        }

        public mPizza Delete(int Id)
        {
            mPizza mPizza = mPizza.Build();
            try
            {
                var Context = EFContext.Build();

                mPizza = GetId(Id);

                Context.Entry(GetId(Id)).State = EntityState.Deleted;
                Context.SaveChanges();
                mPizza.State.IsError = false;
                mPizza.State.MessageSucess = "Pizza Deletada com Sucesso";
            }
            catch (Exception ex)
            {
                mPizza.State.IsError = true;
                mPizza.State.MessageError = ex.Message.ToString();
            }

            return mPizza;
        }
    }
}