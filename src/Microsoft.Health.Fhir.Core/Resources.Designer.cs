﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Health.Fhir.Core.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} and {1} cannot be both specified..
        /// </summary>
        internal static string AtAndSinceCannotBeBothSpecified {
            get {
                return ResourceManager.GetString("AtAndSinceCannotBeBothSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The authorization permission definition contains one or mroe invalid entries..
        /// </summary>
        internal static string AuthorizationPermissionDefinitionInvalid {
            get {
                return ResourceManager.GetString("AuthorizationPermissionDefinitionInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CapabilityStatement must only have a single item in the &apos;Rest&apos; collection..
        /// </summary>
        internal static string CapabilityStatementSingleRestItem {
            get {
                return ResourceManager.GetString("CapabilityStatementSingleRestItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chained parameter must be a reference search parameter type..
        /// </summary>
        internal static string ChainedParameterMustBeReferenceSearchParamType {
            get {
                return ResourceManager.GetString("ChainedParameterMustBeReferenceSearchParamType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The chained parameter is not supported..
        /// </summary>
        internal static string ChainedParameterNotSupported {
            get {
                return ResourceManager.GetString("ChainedParameterNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The comparator &apos;{0}&apos; is not supported for search parameter &apos;{1}&apos;..
        /// </summary>
        internal static string ComparatorNotSupported {
            get {
                return ResourceManager.GetString("ComparatorNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deleting a specific record version is not supported..
        /// </summary>
        internal static string DeleteVersionNotAllowed {
            get {
                return ResourceManager.GetString("DeleteVersionNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (Id) Must be any combination of upper or lower case ASCII letters (&apos;A&apos;..&apos;Z&apos;, and &apos;a&apos;..&apos;z&apos;, numerals (&apos;0&apos;..&apos;9&apos;), &apos;-&apos; and &apos;.&apos;, with a length limit of 64 characters. (This might be an integer, an un-prefixed OID, UUID or any other identifier pattern that meets these constraints.).
        /// </summary>
        internal static string IdRequirements {
            get {
                return ResourceManager.GetString("IdRequirements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A valid if-match header is required for resource type &apos;{0}&apos;..
        /// </summary>
        internal static string IfMatchHeaderRequiredForResource {
            get {
                return ResourceManager.GetString("IfMatchHeaderRequiredForResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal attribute name &apos;{0}&apos; on element &apos;{1}&apos;.
        /// </summary>
        internal static string IllegalHtmlAttribute {
            get {
                return ResourceManager.GetString("IllegalHtmlAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        internal static string IllegalHtmlDiagnostics {
            get {
                return ResourceManager.GetString("IllegalHtmlDiagnostics", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal element name &apos;{0}&apos;.
        /// </summary>
        internal static string IllegalHtmlElement {
            get {
                return ResourceManager.GetString("IllegalHtmlElement", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The div element must have some non-whitespace content (text or an image).
        /// </summary>
        internal static string IllegalHtmlEmpty {
            get {
                return ResourceManager.GetString("IllegalHtmlEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to XHTML content should be contained within a single &lt;div&gt; element.
        /// </summary>
        internal static string IllegalHtmlOuterDiv {
            get {
                return ResourceManager.GetString("IllegalHtmlOuterDiv", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error while parsing XHTML: {0} Line: {1} Col: {2}.
        /// </summary>
        internal static string IllegalHtmlParsingError {
            get {
                return ResourceManager.GetString("IllegalHtmlParsingError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; with value &apos;{1}&apos; is not supported..
        /// </summary>
        internal static string InvalidBooleanConfigSetting {
            get {
                return ResourceManager.GetString("InvalidBooleanConfigSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The continuation token is invalid..
        /// </summary>
        internal static string InvalidContinuationToken {
            get {
                return ResourceManager.GetString("InvalidContinuationToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; with value &apos;{1}&apos; is not supported. Please select from the following list of supported capabilities: [{2}].&quot;.
        /// </summary>
        internal static string InvalidEnumConfigSetting {
            get {
                return ResourceManager.GetString("InvalidEnumConfigSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported values for field &apos;{0}&apos; were selected. Please check your configured options..
        /// </summary>
        internal static string InvalidListConfigSetting {
            get {
                return ResourceManager.GetString("InvalidListConfigSetting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The role was not found..
        /// </summary>
        internal static string InvalidRoleName {
            get {
                return ResourceManager.GetString("InvalidRoleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The count must be greater than zero..
        /// </summary>
        internal static string InvalidSearchCountSpecified {
            get {
                return ResourceManager.GetString("InvalidSearchCountSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value should be a boolean string if :missing modifier is specified..
        /// </summary>
        internal static string InvalidValueTypeForMissingModifier {
            get {
                return ResourceManager.GetString("InvalidValueTypeForMissingModifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {0} returned null..
        /// </summary>
        internal static string MethodReturnedNull {
            get {
                return ResourceManager.GetString("MethodReturnedNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The modifier &apos;{0}&apos; is not supported for search parameter &apos;{1}&apos;..
        /// </summary>
        internal static string ModifierNotSupported {
            get {
                return ResourceManager.GetString("ModifierNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than one token separator character specified..
        /// </summary>
        internal static string MoreThanOneTokenSeparatorSpecified {
            get {
                return ResourceManager.GetString("MoreThanOneTokenSeparatorSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to More than two token separator characters specified..
        /// </summary>
        internal static string MoreThanTwoTokenSeparatorSpecified {
            get {
                return ResourceManager.GetString("MoreThanTwoTokenSeparatorSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple &apos;{0}&apos; query parameters cannot be specified..
        /// </summary>
        internal static string MultipleQueryParametersNotAllowed {
            get {
                return ResourceManager.GetString("MultipleQueryParametersNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of composite components specified for search parameter &apos;{0}&apos; exceeded the number of components defined..
        /// </summary>
        internal static string NumberOfCompositeComponentsExceeded {
            get {
                return ResourceManager.GetString("NumberOfCompositeComponentsExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only equal comparator is supported for this search type..
        /// </summary>
        internal static string OnlyEqualComparatorIsSupported {
            get {
                return ResourceManager.GetString("OnlyEqualComparatorIsSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only one modifier separator can be specified. Value: &apos;{0}&apos;..
        /// </summary>
        internal static string OnlyOneModifierSeparatorSupported {
            get {
                return ResourceManager.GetString("OnlyOneModifierSeparatorSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was a problem with retrieving the OpenId configuration from the authentication provider..
        /// </summary>
        internal static string OpenIdConfiguration {
            get {
                return ResourceManager.GetString("OpenIdConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ReadHistory is disabled for resources of type &apos;{0}&apos;..
        /// </summary>
        internal static string ReadHistoryDisabled {
            get {
                return ResourceManager.GetString("ReadHistoryDisabled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The requested action was not allowed.
        /// </summary>
        internal static string RequestedActionNotAllowed {
            get {
                return ResourceManager.GetString("RequestedActionNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource creation is not allowed..
        /// </summary>
        internal static string ResourceCreationNotAllowed {
            get {
                return ResourceManager.GetString("ResourceCreationNotAllowed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource type &apos;{0}&apos; with id &apos;{1}&apos; couldn&apos;t be found..
        /// </summary>
        internal static string ResourceNotFoundById {
            get {
                return ResourceManager.GetString("ResourceNotFoundById", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Resource type &apos;{0}&apos; with id &apos;{1}&apos; and version &apos;{2}&apos; couldn&apos;t be found..
        /// </summary>
        internal static string ResourceNotFoundByIdAndVersion {
            get {
                return ResourceManager.GetString("ResourceNotFoundByIdAndVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The resource type &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string ResourceNotSupported {
            get {
                return ResourceManager.GetString("ResourceNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Role does not have any ResourcePermission.&quot;.
        /// </summary>
        internal static string ResourcePermissionEmpty {
            get {
                return ResourceManager.GetString("ResourcePermissionEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The supplied version &apos;{0}&apos; did not match..
        /// </summary>
        internal static string ResourceVersionConflict {
            get {
                return ResourceManager.GetString("ResourceVersionConflict", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;Role name cannot be null or empty.&quot;.
        /// </summary>
        internal static string RoleNameEmpty {
            get {
                return ResourceManager.GetString("RoleNameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rolepermission for Role {0} has invalid filter expression..
        /// </summary>
        internal static string RolePermissionWithInvalidTemplateExpression {
            get {
                return ResourceManager.GetString("RolePermissionWithInvalidTemplateExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rolepermission for Role {0} does not have any Actions..
        /// </summary>
        internal static string RolePermissionWithNoAction {
            get {
                return ResourceManager.GetString("RolePermissionWithNoAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rolepermission for Role {0} has no template expression..
        /// </summary>
        internal static string RolePermissionWithNoTemplateExpression {
            get {
                return ResourceManager.GetString("RolePermissionWithNoTemplateExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparator is not supported when multiple values are specified using OR search parameter..
        /// </summary>
        internal static string SearchComparatorNotSupported {
            get {
                return ResourceManager.GetString("SearchComparatorNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search parameter with definition URL &apos;{0}&apos; is not supported..
        /// </summary>
        internal static string SearchParameterByDefinitionUriNotSupported {
            get {
                return ResourceManager.GetString("SearchParameterByDefinitionUriNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].resource.base is not defined..
        /// </summary>
        internal static string SearchParameterDefinitionBaseNotDefined {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionBaseNotDefined", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].component[{1}] cannot be pointing to a composite SearchParameter..
        /// </summary>
        internal static string SearchParameterDefinitionComponentReferenceCannotBeComposite {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionComponentReferenceCannotBeComposite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search parameter definition contains one or mroe invalid entries..
        /// </summary>
        internal static string SearchParameterDefinitionContainsInvalidEntry {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionContainsInvalidEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A search parameter with the same definition URL &apos;{0}&apos; already exists..
        /// </summary>
        internal static string SearchParameterDefinitionDuplicatedEntry {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionDuplicatedEntry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].component is null or empty..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidComponent {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidComponent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].component[{1}].expression is null or empty..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidComponentExpression {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidComponentExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].component[{1}].definition.reference is null or empty, or is not pointing to a valid SearchParameter resource..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidComponentReference {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidComponentReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].url is invalid..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidDefinitionUri {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidDefinitionUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].resource.expression is null or empty..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidExpression {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidExpression", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bundle.entry[{0}].resource is not a SearchParameter resource..
        /// </summary>
        internal static string SearchParameterDefinitionInvalidResource {
            get {
                return ResourceManager.GetString("SearchParameterDefinitionInvalidResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The search parameter &apos;{0}&apos; is not supported for resource type &apos;{1}&apos;..
        /// </summary>
        internal static string SearchParameterNotSupported {
            get {
                return ResourceManager.GetString("SearchParameterNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft FHIR Server.
        /// </summary>
        internal static string ServerName {
            get {
                return ResourceManager.GetString("ServerName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation could not be completed because the service was unable to accept new requests. It is safe to retry the operation. If the issue persists, please contact support..
        /// </summary>
        internal static string ServiceUnavailable {
            get {
                return ResourceManager.GetString("ServiceUnavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified resource type &apos;{0}&apos; is not a reference type..
        /// </summary>
        internal static string SpecifiedResourceTypeIsNotReferenceType {
            get {
                return ResourceManager.GetString("SpecifiedResourceTypeIsNotReferenceType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsupported Configuration was selected.
        /// </summary>
        internal static string UnsupportedConfigurationMessage {
            get {
                return ResourceManager.GetString("UnsupportedConfigurationMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update requests must contain an Id.
        /// </summary>
        internal static string UpdateRequestsRequireId {
            get {
                return ResourceManager.GetString("UpdateRequestsRequireId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to VersionId should not be in the weak ETag format.
        /// </summary>
        internal static string VersionIdFormatNotETag {
            get {
                return ResourceManager.GetString("VersionIdFormatNotETag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to WeakETag must be in the weak ETag format.
        /// </summary>
        internal static string WeakETagFormatRequired {
            get {
                return ResourceManager.GetString("WeakETagFormatRequired", resourceCulture);
            }
        }
    }
}
