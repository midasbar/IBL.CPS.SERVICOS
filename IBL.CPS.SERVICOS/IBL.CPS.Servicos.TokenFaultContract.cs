using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using System.ServiceModel;
using IBL.CPS.UTILS;

namespace IBL.CPS.SERVICOS
{
    public class TokenFaultContract
    {
        public string ErrorMessage { get; set; }
    }

    public class TokenInspectorAttribute : Attribute, IParameterInspector, IOperationBehavior
    {
        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {

        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            Console.WriteLine("Caiu no Before");
            if (inputs != null && inputs.Length > 0)
            {
                var token = (String)inputs[inputs.Length - 1];
                if (!TokenUtils.IsValidToken(token))
                {
                    var fc = new TokenFaultContract { ErrorMessage = TokenUtils.GetInvalidTokenMessage() };
                    throw new FaultException<TokenFaultContract>(fc);
                }
            }
            return null;
        }

        public void AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(this);
        }

        public void Validate(OperationDescription operationDescription)
        {
        }
    }

   
}