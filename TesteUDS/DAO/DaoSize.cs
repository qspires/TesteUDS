using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TesteUDS.Models;

namespace TesteUDS.DAO
{
    public class DaoSize
    {
        public static DaoSize Build()
        {
            return new DaoSize();
        }


        public List<mSize> GetAll()
        {
            return EFContext.Build().mSize.ToList();
        }

        public mSize GetId(int Id)
        {
            return EFContext.Build().mSize.Find(Id);
        }


        public mSize Insert(mSize mSize)
        {
            try
            {
                var Context = EFContext.Build();

                Context.mSize.Add(mSize);
                Context.SaveChanges();

                mSize.State.IsError = false;
                mSize.State.MessageSucess = "Tamanho Cadastro com Sucesso";
            }
            catch (Exception ex)
            {
                mSize.State.IsError = true;
                mSize.State.MessageError = ex.Message.ToString();
            }
            return mSize;
        }

        public mSize Update(mSize mSize)
        {
            try
            {
                var Context = EFContext.Build();

                mSize Model = GetId(mSize.Id);

                Context.Entry(Model.SetSize(mSize)).State = EntityState.Modified;
                Context.SaveChanges();

                mSize.State.IsError = false;
                mSize.State.MessageSucess = "Tamanho Atualizado com Sucesso";
            }
            catch (Exception ex)
            {
                mSize.State.IsError = true;
                mSize.State.MessageError = ex.Message.ToString();
            }

            return mSize;
        }

        public mSize Delete(int Id)
        {
            mSize mSize = mSize.Build();
            try
            {
                var Context = EFContext.Build();

                Context.Entry(GetId(Id)).State = EntityState.Deleted;
                Context.SaveChanges();
                mSize.State.IsError = false;
                mSize.State.MessageSucess = "Tamanho Delatado com Sucesso";
            }
            catch (Exception ex)
            {
                mSize.State.IsError = true;
                mSize.State.MessageError = ex.Message.ToString();
            }

            return mSize;
        }
    }
}