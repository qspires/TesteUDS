using TesteUDS.DAO;
using TesteUDS.Models;

namespace TesteUDS.Manager
{
    public class ExtraOnOrderManager
    {
        public static ExtraOnOrderManager Build()
        {
            return new ExtraOnOrderManager();
        }


        public mOrder CreateExtra(int IdOrder, int IdExtra)
        {

            mExtraOnOrder mExtraOnOrder = mExtraOnOrder.Build();


            mOrder mOrder = DaoOrder.Build().GetId(IdOrder);
            if (mOrder != null)
            {
                mExtraOnOrder.IdOrder = mOrder.Id;
            }
            else
            {
                mOrder = mOrder.Build();
                mOrder.State.IsError = true;
                mOrder.State.MessageError = "ID do Pedido não foi encontrado";

                return mOrder;
            }


            mExtra mExtra = DaoExtra.Build().GetId(IdExtra);
            if (mExtra != null)
            {
                mExtraOnOrder.IdExtra = mExtra.Id;
                mOrder.Amount = mOrder.Amount + mExtra.Amount;
                mOrder.Time = mOrder.Time + mExtra.Time;
            }
            else
            {
                mOrder.State.IsError = true;
                mOrder.State.MessageError = "ID do Adicional não foi encontrado";
                return mOrder;
            }

            mExtraOnOrder = DaoExtraOnOrder.Build().Insert(mExtraOnOrder);

            if (!mExtraOnOrder.State.IsError)
            {
                mOrder = DaoOrder.Build().Update(mOrder);
            }
            else
            {
                mOrder.State = mExtraOnOrder.State;
            }

            return mOrder;
        }

    }
}