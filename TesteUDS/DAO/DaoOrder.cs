using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS.DAO
{
    public class DaoOrder
    {
        public static DaoOrder Build()
        {
            return new DaoOrder();
        }


        public List<mOrder> GetAll()
        {
            return EFContext.Build().mOrder.Include("mSize").Include("mPizza").Include("mExtraOnOrder").Include("mExtraOnOrder.mExtra").ToList();
        }

        public mOrder GetId(int Id)
        {
            return EFContext.Build().mOrder.Include("mSize").Include("mPizza").Include("mExtraOnOrder").Include("mExtraOnOrder.mExtra").Where(x => x.Id == Id).Take(1).SingleOrDefault();
        }


        public mOrder Insert(mOrder mOrder)
        {
            try
            {
                var Context = EFContext.Build();


                mOrder.DateCreate = mOrder.DateCreate ?? DateTime.Now;
                mOrder.Quantity = 1;

                Context.mOrder.Add(mOrder);
                Context.SaveChanges();

                mOrder.State.IsError = false;
                mOrder.State.MessageSucess = "Pedido Cadastro com Sucesso";
            }
            catch (Exception ex)
            {
                mOrder.State.IsError = true;
                mOrder.State.MessageError = ex.Message.ToString();
            }
            return mOrder;
        }

        public mOrder Update(mOrder mOrder)
        {
            try
            {
                var Context = EFContext.Build();

                mOrder Model = GetId(mOrder.Id);

                Context.Entry(Model.SetOrder(mOrder)).State = EntityState.Modified;
                Context.SaveChanges();

                mOrder.State.IsError = false;
                mOrder.State.MessageSucess = "Pedido Atualizado com Sucesso";
            }
            catch (Exception ex)
            {
                mOrder.State.IsError = true;
                mOrder.State.MessageError = ex.Message.ToString();
            }

            return mOrder;
        }

        public mOrder Delete(int Id)
        {
            mOrder mOrder = mOrder.Build();
            try
            {
                var Context = EFContext.Build();

                Context.Entry(GetId(Id)).State = EntityState.Deleted;
                Context.SaveChanges();
                mOrder.State.IsError = false;
                mOrder.State.MessageSucess = "Pedido Delatado com Sucesso";
            }
            catch (Exception ex)
            {
                mOrder.State.IsError = true;
                mOrder.State.MessageError = ex.Message.ToString();
            }

            return mOrder;
        }
    }
}