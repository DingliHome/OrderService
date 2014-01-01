using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;

namespace WebHost.Common
{
    public class ProxyDataContractResolver : DataContractResolver
    {
        private XsdDataContractExporter _exporter = new XsdDataContractExporter();
        public override bool TryResolveType(Type type, Type declaredType, DataContractResolver knownTypeResolver,
            out XmlDictionaryString typeName, out XmlDictionaryString typeNamespace)
        {
            var objectType = ObjectContext.GetObjectType(type);
            if (objectType != type)
            {
                // Type was a proxy type, so map the name to the non-proxy name
                XmlQualifiedName qualifiedName = _exporter.GetSchemaTypeName(objectType);
                XmlDictionary dictionary = new XmlDictionary(2);
                typeName = new XmlDictionaryString(dictionary,
                                                   qualifiedName.Name, 0);
                typeNamespace = new XmlDictionaryString(dictionary,
                                                         qualifiedName.Namespace, 1);
                return true;
            }
            else
            {
                // Type was not a proxy type, so do the default
                return knownTypeResolver.TryResolveType(
                                          type,
                                          declaredType,
                                          null,
                                          out typeName,
                                          out typeNamespace);
            }
        }

        public override Type ResolveName(string typeName, string typeNamespace, Type declaredType, DataContractResolver knownTypeResolver)
        {
            return knownTypeResolver.ResolveName(typeName, typeNamespace, declaredType, null);
        }
    }
}