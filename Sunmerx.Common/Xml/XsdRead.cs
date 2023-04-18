using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.CSharp;

namespace Sunmerx.Common.Xml
{
    public class XsdRead
    {
        public static void GenerateCode()
        {
            //XmlSchemas schemas = new XmlSchemas();
            //schemas.Add(new XmlSchema() {});

            //CodeNamespace codeNamespace = new CodeNamespace("MyNamespace");
            //XmlSchemaImporter schemaImporter = new XmlSchemaImporter(schemas);
            //XmlCodeExporter codeExporter = new XmlCodeExporter(codeNamespace);

            //foreach ( XmlSchema schema in schemas.Schemas() )
            //{
            //    schemaImporter.ImportSchema(schema);
            //}

            //foreach ( CodeNamespace ns in codeExporter.GeneratedCode.Namespaces )
            //{
            //    foreach ( CodeTypeDeclaration type in ns.Types )
            //    {
            //        CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            //        CodeGeneratorOptions options = new CodeGeneratorOptions();
            //        options.BracingStyle = "C";
            //        using ( StreamWriter writer = new StreamWriter("path/to/your/output/file.cs") )
            //        {
            //            provider.GenerateCodeFromType(type , writer , options);
            //        }
            //    }
            //}
            // Load the schema file
            //XmlSchema schema = XmlSchema.Read(new StreamReader("schema.xsd") , null);

            //// Create a CodeCompileUnit to hold the generated code
            //CodeCompileUnit compileUnit = new CodeCompileUnit();

            //// Create a CodeNamespace to hold the generated types
            //CodeNamespace codeNamespace = new CodeNamespace("MyNamespace");

            //// Create a CodeDomProvider to generate the code
            //CodeDomProvider codeProvider = new CSharpCodeProvider();

            //// Create a CodeTypeDeclaration for each complex type in the schema
            //foreach ( XmlSchemaComplexType complexType in schema.SchemaTypes.Values.OfType<XmlSchemaComplexType>() )
            //{
            //    CodeTypeDeclaration typeDeclaration = new CodeTypeDeclaration(complexType.Name);
            //    typeDeclaration.IsClass = true;

            //    // Create a CodeTypeReference for the base class
            //    if ( complexType.BaseXmlSchemaType != null )
            //    {
            //        CodeTypeReference baseTypeReference = new CodeTypeReference(complexType.BaseXmlSchemaType.QualifiedName.Name);
            //        typeDeclaration.BaseTypes.Add(baseTypeReference);
            //    }

            //    // Create a CodeTypeReference for each attribute
            //    foreach ( XmlSchemaAttribute attribute in complexType.Attributes.OfType<XmlSchemaAttribute>() )
            //    {
            //        CodeMemberField field = new CodeMemberField(new CodeTypeReference(attribute.AttributeSchemaType.QualifiedName.Name) , attribute.Name);
            //        typeDeclaration.Members.Add(field);
            //    }

            //    // Create a CodeTypeReference for each element

            //    foreach ( XmlSchemaElement element in complexType.ContentTypeParticle.OfType<XmlSchemaElement>() )
            //    {
            //        CodeMemberField field = new CodeMemberField(new CodeTypeReference(element.ElementSchemaType.QualifiedName.Name) , element.Name);
            //        typeDeclaration.Members.Add(field);
            //    }

            //    // Add the type to the namespace
            //    codeNamespace.Types.Add(typeDeclaration);
            //}

            //// Add the namespace to the compile unit
            //compileUnit.Namespaces.Add(codeNamespace);

            //// Generate the code
            //using ( StreamWriter writer = new StreamWriter("output.cs") )
            //{
            //    codeProvider.GenerateCodeFromCompileUnit(compileUnit , writer , new CodeGeneratorOptions());
            //}
        }
    }
}
