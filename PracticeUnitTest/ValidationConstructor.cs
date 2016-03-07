using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracticeUnitTest
{
    public class ValidationConstructor
    {
        private IAccountDoc _accountDoc;
        private IHash _hash;

        public ValidationConstructor(IAccountDoc doc, IHash hash)
        {
            this._accountDoc = doc;
            this._hash = hash;
        }

        public bool CheckAuthentication(string id, string password)
        { 

            //get the password that matches with the input ID

            var passwordByDoc = this._accountDoc.GetPassword(id);

            //conduct Hash calulation for the input password
           
            var hashResult = this._hash.GetHashResult(password);

            //compare the input password(after hash) and the password get from the system
            return passwordByDoc == hashResult;
        }
    }

    public interface IHash
    {
        string GetHashResult(string password);
    }

    public interface IAccountDoc
    {
        string GetPassword(string id);
    }

    public class AccountDoc : IAccountDoc
    {
        public string GetPassword(string id)
        {
            throw new NotImplementedException();
        }
    }

    public class Hash : IHash
    {
        public string GetHashResult(string password)
        {
            throw new NotImplementedException();
        }
    }

    /**
    public class StubAccountDoc : IAccountDoc
    {
        public string GetPassword(string id)
        {
            return "91";
        }
    }

    public class StubHash : IHash
    {
        public string GetHashResult(string password)
        {
            return "91";
        }
    }
    **/
}
