using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS.DAO
{
    public class DaoExtraOnOrder
    {
        public static DaoExtraOnOrder Build()
        {
            return new DaoExtraOnOrder();
        }


        public List<mExtraOnOrder> GetAll()
        {
            return EFContext.Build().mExtraOnOrder.ToList();
        }

        public mExtraOnOrder GetId(int Id)
        {
            return EFContext.Build().mExtraOnOrder.Find(Id);
        }


        public mExtraOnOrder Insert(mExtraOnOrder mExtraOnOrder)
        {
            try
            {
                var Context = EFContext.Build();

                Context.mExtraOnOrder.Add(mExtraOnOrder);
                Context.SaveChanges();

                mExtraOnOrder.State.IsError = false;
                mExtraOnOrder.State.MessageSucess = "Adicional Cadastro com Sucesso";
            }
            catch (Exception ex)
            {
                mExtraOnOrder.State.IsError = true;
                mExtraOnOrder.State.MessageError = ex.Message.ToString();
            }
            return mExtraOnOrder;
        }

        public mExtraOnOrder Update(mExtraOnOrder mExtraOnOrder)
        {
            try
            {
                var Context = EFContext.Build();

                mExtraOnOrder Model = GetId(mExtraOnOrder.Id);

                Context.Entry(Model.SetExtraOnOrder(mExtraOnOrder)).State = EntityState.Modified;
                Context.SaveChanges();

                mExtraOnOrder.State.IsError = false;
                mExtraOnOrder.State.MessageSucess = "Adicional Atualizado com Sucesso";
            }
            catch (Exception ex)
            {
                mExtraOnOrder.State.IsError = true;
                mExtraOnOrder.State.MessageError = ex.Message.ToString();
            }

            return mExtraOnOrder;
        }

        public mExtraOnOrder Delete(int Id)
        {
            mExtraOnOrder mExtraOnOrder = mExtraOnOrder.Build();
            try
            {
                var Context = EFContext.Build();

                Context.Entry(GetId(Id)).State = EntityState.Deleted;
                Context.SaveChanges();
                mExtraOnOrder.State.IsError = false;
                mExtraOnOrder.State.MessageSucess = "Adicional Delatado com Sucesso";
            }
            catch (Exception ex)
            {
                mExtraOnOrder.State.IsError = true;
                mExtraOnOrder.State.MessageError = ex.Message.ToString();
            }

            return mExtraOnOrder;
        }
    }
}