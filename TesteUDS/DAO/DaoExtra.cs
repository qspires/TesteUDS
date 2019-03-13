using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS.DAO
{
    public class DaoExtra
    {
        public static DaoExtra Build()
        {
            return new DaoExtra();
        }


        public List<mExtra> GetAll()
        {
            return EFContext.Build().mExtra.ToList();
        }

        public mExtra GetId(int Id)
        {
            return EFContext.Build().mExtra.Find(Id);
        }


        public mExtra Insert(mExtra mExtra)
        {
            try
            {
                var Context = EFContext.Build();

                Context.mExtra.Add(mExtra);
                Context.SaveChanges();

                mExtra.State.IsError = false;
                mExtra.State.MessageSucess = "Adicional Cadastro com Sucesso";
            }
            catch (Exception ex)
            {
                mExtra.State.IsError = true;
                mExtra.State.MessageError = ex.Message.ToString();
            }
            return mExtra;
        }

        public mExtra Update(mExtra mExtra)
        {
            try
            {
                var Context = EFContext.Build();

                mExtra Model = GetId(mExtra.Id);

                Context.Entry(Model.SetExtra(mExtra)).State = EntityState.Modified;
                Context.SaveChanges();

                mExtra.State.IsError = false;
                mExtra.State.MessageSucess = "Adicional Atualizado com Sucesso";
            }
            catch (Exception ex)
            {
                mExtra.State.IsError = true;
                mExtra.State.MessageError = ex.Message.ToString();
            }

            return mExtra;
        }

        public mExtra Delete(int Id)
        {
            mExtra mExtra = mExtra.Build();
            try
            {
                var Context = EFContext.Build();

                Context.Entry(GetId(Id)).State = EntityState.Deleted;
                Context.SaveChanges();
                mExtra.State.IsError = false;
                mExtra.State.MessageSucess = "Adicional Delatado com Sucesso";
            }
            catch (Exception ex)
            {
                mExtra.State.IsError = true;
                mExtra.State.MessageError = ex.Message.ToString();
            }

            return mExtra;
        }
    }
}