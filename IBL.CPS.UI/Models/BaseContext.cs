using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;
using IBL.CPS.UTILS;


namespace IBL.CPS.UI.Engine
{
    public interface IServiceClient<D, F>: IDisposable 
        where D: IDTOClient
        where F: IFTRClient
    {
        void Incluir(D dto, string token);
        void Gravar(D dto, string token);
        void Excluir(int id, string token);
        D[] ObterLista(F ftr, string token);
        D Obter(int id, string token);
    }

    public interface IDTOClient
    {
        int ID { get; set; }
    }

    public interface IFTRClient
    {
        //Int32 Id { get; set; }
    }


    public interface IBaseContext<D, F> where D : IDTOClient where F: IFTRClient
    {

       

        List<D> ObterLista(F filter);

        void Incluir(D model);

        void Gravar(D model);

        void Excluir(int id);

        D Obter(int id);

    }

    public abstract class BaseContext<D, F, S> : IBaseContext<D, F> 
        where D : IDTOClient
        where F : IFTRClient, new()
        where S : IServiceClient<D, F>, new()
    {
       

        public List<D> ObterLista(F ftr)
        {
            List<D> result = null;
            using (var cs = new S())
            {  
                if (ftr == null) ftr = new F();
                result = cs.ObterLista(ftr, TokenUtils.GetToken()).ToList();
            }

            return result;

        }

        public void Incluir(D model)
        {
            using (var sc = new S())
            {
                sc.Incluir(model, TokenUtils.GetToken());
            }

        }

        public void Gravar(D model)
        {
            using (var sc = new S())
            {
                sc.Gravar(model, TokenUtils.GetToken());
            }
        }

        public void Excluir(int id)
        {
            using (var sc = new S())
            {
                sc.Excluir(id, TokenUtils.GetToken());
            }

        }

        public D Obter(int id)
        {
            D result = default(D);
            using (var sc = new S())
            {
                result = sc.Obter(id, TokenUtils.GetToken());
            }

            return result;

        }

    }
}