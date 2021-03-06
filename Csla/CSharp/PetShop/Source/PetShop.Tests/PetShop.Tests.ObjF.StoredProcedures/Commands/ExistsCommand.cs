﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated using CodeSmith: v6.0.2, CSLA Templates: v3.0.3.2396, CSLA Framework: v4.0.0.
//     Changes to this file will be lost after each regeneration.
//
//     Template: ExistsCommand.cst
//     Template website: http://code.google.com/p/codesmith/
// </autogenerated>
//------------------------------------------------------------------------------
#region Using declarations

using System;

using System.Data.SqlClient;

using Csla;
using Csla.Data;

#endregion

namespace PetShop.Tests.StoredProcedures
{
    [Serializable]
    public class ExistsCommand : CommandBase<ExistsCommand>
    {
        #region Constructor(s)

        private ExistsCommand()
        {
        }


        #endregion

        #region Authorization Methods

        public static bool CanExecuteCommand()
        {
            return true;
        }

        #endregion

        #region Synchronous Factory Methods 

        public static bool Execute<T>(T criteria) where T : PetShop.Tests.StoredProcedures.IGeneratedCriteria
        {
            if (!CanExecuteCommand())
                throw new System.Security.SecurityException("Not authorized to execute command");

            var cmd = new ExistsCommand();
            cmd.BeforeServer(criteria);
            cmd = DataPortal.Execute(cmd);
            cmd.AfterServer();

            return cmd.Result;
        }

        #endregion

        #region Client-side Code

        private PetShop.Tests.StoredProcedures.IGeneratedCriteria Criteria { get; set; }
        public bool Result { get; private set; }

        private void BeforeServer(PetShop.Tests.StoredProcedures.IGeneratedCriteria criteria)
        {
            Criteria = criteria;
            Result = false;
        }

        private void AfterServer()
        {
        }

        #endregion

        #region Data Access

        protected override void DataPortal_Execute()
        {
            string commandText = string.Format("SELECT COUNT(1) FROM {0} {1}", Criteria.TableFullName, ADOHelper.BuildWhereStatement(Criteria.StateBag));
            using (SqlConnection connection = new SqlConnection(ADOHelper.ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    command.Parameters.AddRange(ADOHelper.SqlParameters(Criteria.StateBag));
                    Result = (int)command.ExecuteScalar() > 0;
                }
            }
        }

        #endregion

    }
}