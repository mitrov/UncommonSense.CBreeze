#
# Module manifest for module 'PSGet_manifest'
#
# Generated by: Jan Hoek
#
# Generated on: 26-06-18
#

@{

# Script module or binary module file associated with this manifest.
RootModule = 'UncommonSense.CBreeze.Automation.dll'

# Version number of this module.
ModuleVersion = '1.0.1.5'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = '999a0b81-d816-4d68-8337-f70c1096f30e'

# Author of this module
Author = 'Jan Hoek'

# Company or vendor of this module
CompanyName = 'uncommonsense.nl'

# Copyright statement for this module
Copyright = 'Copyright (c) 2015 Jan Hoek. All rights reserved.'

# Description of the functionality provided by this module
Description = 'PowerShell API for the Dynamics NAV object text format'

# Minimum version of the Windows PowerShell engine required by this module
# PowerShellVersion = ''

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.5'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
# RequiredModules = @()

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
ScriptsToProcess = 'UncommonSense.CBreeze.Automation.ps1'

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'UncommonSense.CBreeze.Automation.Format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = 'TableNameCompleter', 'PageNameCompleter', 'ImageNameCompleter'

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Compile-CBreezeApplication', 'Export-CBreezeApplication', 
               'Get-CBreezePageActionContainer', 'Get-CBreezePageActionGroup', 
               'Get-CBreezePageControlContainer', 'Get-CBreezePageControlGroup', 
               'Get-CBreezeVariableName', 'Import-CBreezeApplication', 
               'Invoke-CBreezeObject', 'New-CBreezeAccessByPermission', 
               'New-CBreezeActionParameter', 'New-CBreezeActionVariable', 
               'New-CBreezeApplication', 'New-CBreezeAutomationParameter', 
               'New-CBreezeAutomationVariable', 'New-CBreezeBigIntegerParameter', 
               'New-CBreezeBigIntegerTableField', 'New-CBreezeBigIntegerVariable', 
               'New-CBreezeBigTextParameter', 'New-CBreezeBigTextVariable', 
               'New-CBreezeBinaryParameter', 'New-CBreezeBinaryTableField', 
               'New-CBreezeBinaryVariable', 'New-CBreezeBlobTableField', 
               'New-CBreezeBooleanParameter', 'New-CBreezeBooleanTableField', 
               'New-CBreezeBooleanVariable', 
               'New-CBreezeBusinessEventPublisherFunction', 
               'New-CBreezeByteParameter', 'New-CBreezeByteVariable', 
               'New-CBreezeCalcFormula', 'New-CBreezeCalcFormulaFilter', 
               'New-CBreezeCharParameter', 'New-CBreezeCharVariable', 
               'New-CBreezeClientTypeParameter', 'New-CBreezeClientTypeVariable', 
               'New-CBreezeCodeLine', 'New-CBreezeCodeParameter', 
               'New-CBreezeCodeTableField', 'New-CBreezeCodeunit', 
               'New-CBreezeCodeunitParameter', 'New-CBreezeCodeunitVariable', 
               'New-CBreezeCodeVariable', 'New-CBreezeColumnQueryElement', 
               'New-CBreezeColumnReportElement', 'New-CBreezeDataItemQueryElement', 
               'New-CBreezeDataItemReportElement', 
               'New-CBreezeDateFormulaParameter', 
               'New-CBreezeDateFormulaTableField', 
               'New-CBreezeDateFormulaVariable', 'New-CBreezeDateParameter', 
               'New-CBreezeDateTableField', 'New-CBreezeDateTimeParameter', 
               'New-CBreezeDateTimeTableField', 'New-CBreezeDateTimeVariable', 
               'New-CBreezeDateVariable', 'New-CBreezeDecimalParameter', 
               'New-CBreezeDecimalTableField', 'New-CBreezeDecimalVariable', 
               'New-CBreezeDefaultLayoutParameter', 
               'New-CBreezeDefaultLayoutVariable', 'New-CBreezeDeltaMenuSuiteNode', 
               'New-CBreezeDialogParameter', 'New-CBreezeDialogVariable', 
               'New-CBreezeDotNetParameter', 'New-CBreezeDotNetVariable', 
               'New-CBreezeDurationParameter', 'New-CBreezeDurationTableField', 
               'New-CBreezeDurationVariable', 'New-CBreezeEvent', 
               'New-CBreezeEventSubscriberFunction', 
               'New-CBreezeExecutionModeParameter', 
               'New-CBreezeExecutionModeVariable', 'New-CBreezeFieldRefParameter', 
               'New-CBreezeFieldRefVariable', 'New-CBreezeFileParameter', 
               'New-CBreezeFileVariable', 'New-CBreezeFilter', 
               'New-CBreezeFilterPageBuilderParameter', 
               'New-CBreezeFilterPageBuilderVariable', 
               'New-CBreezeFilterQueryElement', 'New-CBreezeFunction', 
               'New-CBreezeGroupMenuSuiteNode', 'New-CBreezeGuidParameter', 
               'New-CBreezeGuidTableField', 'New-CBreezeGuidVariable', 
               'New-CBreezeInStreamParameter', 'New-CBreezeInStreamVariable', 
               'New-CBreezeIntegerParameter', 'New-CBreezeIntegerTableField', 
               'New-CBreezeIntegerVariable', 
               'New-CBreezeIntegrationEventPublisherFunction', 
               'New-CBreezeItemMenuSuiteNode', 'New-CBreezeKeyRefParameter', 
               'New-CBreezeKeyRefVariable', 'New-CBreezeMediaSetTableField', 
               'New-CBreezeMediaTableField', 'New-CBreezeMenuMenuSuiteNode', 
               'New-CBreezeMenuSuite', 'New-CBreezeNotificationParameter', 
               'New-CBreezeNotificationScopeParameter', 
               'New-CBreezeNotificationScopeVariable', 
               'New-CBreezeNotificationVariable', 'New-CBreezeObjectTypeParameter', 
               'New-CBreezeObjectTypeVariable', 'New-CBreezeOcxParameter', 
               'New-CBreezeOcxVariable', 'New-CBreezeOptionParameter', 
               'New-CBreezeOptionTableField', 'New-CBreezeOptionVariable', 
               'New-CBreezeOrderBy', 'New-CBreezeOutStreamParameter', 
               'New-CBreezeOutStreamVariable', 'New-CBreezePage', 
               'New-CBreezePageAction', 'New-CBreezePageActionContainer', 
               'New-CBreezePageActionGroup', 'New-CBreezePageActionSeparator', 
               'New-CBreezePageControl', 'New-CBreezePageControlContainer', 
               'New-CBreezePageControlGroup', 'New-CBreezePageControlPart', 
               'New-CBreezePageParameter', 'New-CBreezePageVariable', 
               'New-CBreezePermission', 'New-CBreezeQuery', 'New-CBreezeQueryLink', 
               'New-CBreezeQueryOrderBy', 'New-CBreezeQueryParameter', 
               'New-CBreezeQueryVariable', 'New-CBreezeRecordIDParameter', 
               'New-CBreezeRecordIDTableField', 'New-CBreezeRecordIDVariable', 
               'New-CBreezeRecordParameter', 'New-CBreezeRecordRefParameter', 
               'New-CBreezeRecordRefVariable', 'New-CBreezeRecordVariable', 
               'New-CBreezeReport', 'New-CBreezeReportFormatParameter', 
               'New-CBreezeReportFormatVariable', 'New-CBreezeReportLabel', 
               'New-CBreezeReportLink', 'New-CBreezeReportParameter', 
               'New-CBreezeReportVariable', 'New-CBreezeRootMenuSuiteNode', 
               'New-CBreezeRunObjectLink', 'New-CBreezeTable', 
               'New-CBreezeTableConnectionTypeParameter', 
               'New-CBreezeTableConnectionTypeVariable', 
               'New-CBreezeTableFieldGroup', 'New-CBreezeTableFilterTableField', 
               'New-CBreezeTableKey', 'New-CBreezeTableRelation', 
               'New-CBreezeTableRelationCondition', 
               'New-CBreezeTableRelationFilter', 'New-CBreezeTestFunction', 
               'New-CBreezeTestPageParameter', 'New-CBreezeTestPageVariable', 
               'New-CBreezeTestPermissionsParameter', 
               'New-CBreezeTestPermissionsVariable', 
               'New-CBreezeTestRequestPageParameter', 'New-CBreezeTextConstant', 
               'New-CBreezeTextEncodingParameter', 
               'New-CBreezeTextEncodingVariable', 'New-CBreezeTextParameter', 
               'New-CBreezeTextTableField', 'New-CBreezeTextVariable', 
               'New-CBreezeTimeParameter', 'New-CBreezeTimeTableField', 
               'New-CBreezeTimeVariable', 'New-CBreezeTransactionTypeParameter', 
               'New-CBreezeTransactionTypeVariable', 'New-CBreezeUpgradeFunction', 
               'New-CBreezeVariantParameter', 'New-CBreezeVariantVariable', 
               'New-CBreezeXmlPort', 'New-CBreezeXmlPortFieldAttribute', 
               'New-CBreezeXmlPortFieldElement', 'New-CBreezeXmlPortLink', 
               'New-CBreezeXmlPortParameter', 'New-CBreezeXmlPortTableAttribute', 
               'New-CBreezeXmlPortTableElement', 'New-CBreezeXmlPortTextAttribute', 
               'New-CBreezeXmlPortTextElement', 'New-CBreezeXmlPortVariable', 
               'Set-CBreezeDefaultRanges', 'Set-CBreezeMLValue', 
               'Set-CBreezeXmlPortNamespace'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'AccessByPermission', 'Action', 'ActionContainer', 'ActionGroup', 
               'ActionParameter', 'ActionSeparator', 'ActionVariable', 
               'Add-CBreezeAccessByPermission', 'Add-CBreezeActionParameter', 
               'Add-CBreezeActionVariable', 'Add-CBreezeAutomationParameter', 
               'Add-CBreezeAutomationVariable', 'Add-CBreezeBigIntegerParameter', 
               'Add-CBreezeBigIntegerTableField', 'Add-CBreezeBigIntegerVariable', 
               'Add-CBreezeBigTextParameter', 'Add-CBreezeBigTextVariable', 
               'Add-CBreezeBinaryParameter', 'Add-CBreezeBinaryTableField', 
               'Add-CBreezeBinaryVariable', 'Add-CBreezeBlobTableField', 
               'Add-CBreezeBooleanParameter', 'Add-CBreezeBooleanTableField', 
               'Add-CBreezeBooleanVariable', 
               'Add-CBreezeBusinessEventPublisherFunction', 
               'Add-CBreezeByteParameter', 'Add-CBreezeByteVariable', 
               'Add-CBreezeCalcFormulaFilter', 'Add-CBreezeCharParameter', 
               'Add-CBreezeCharVariable', 'Add-CBreezeClientTypeParameter', 
               'Add-CBreezeClientTypeVariable', 'Add-CBreezeCodeLine', 
               'Add-CBreezeCodeParameter', 'Add-CBreezeCodeTableField', 
               'Add-CBreezeCodeunit', 'Add-CBreezeCodeunitParameter', 
               'Add-CBreezeCodeunitVariable', 'Add-CBreezeCodeVariable', 
               'Add-CBreezeColumnQueryElement', 'Add-CBreezeColumnReportElement', 
               'Add-CBreezeDataItemQueryElement', 
               'Add-CBreezeDataItemReportElement', 
               'Add-CBreezeDateFormulaParameter', 
               'Add-CBreezeDateFormulaTableField', 
               'Add-CBreezeDateFormulaVariable', 'Add-CBreezeDateParameter', 
               'Add-CBreezeDateTableField', 'Add-CBreezeDateTimeParameter', 
               'Add-CBreezeDateTimeTableField', 'Add-CBreezeDateTimeVariable', 
               'Add-CBreezeDateVariable', 'Add-CBreezeDecimalParameter', 
               'Add-CBreezeDecimalTableField', 'Add-CBreezeDecimalVariable', 
               'Add-CBreezeDefaultLayoutParameter', 
               'Add-CBreezeDefaultLayoutVariable', 'Add-CBreezeDialogParameter', 
               'Add-CBreezeDialogVariable', 'Add-CBreezeDotNetParameter', 
               'Add-CBreezeDotNetVariable', 'Add-CBreezeDurationParameter', 
               'Add-CBreezeDurationTableField', 'Add-CBreezeDurationVariable', 
               'Add-CBreezeEvent', 'Add-CBreezeEventSubscriberFunction', 
               'Add-CBreezeExecutionModeParameter', 
               'Add-CBreezeExecutionModeVariable', 'Add-CBreezeFieldRefParameter', 
               'Add-CBreezeFieldRefVariable', 'Add-CBreezeFileParameter', 
               'Add-CBreezeFileVariable', 'Add-CBreezeFilter', 
               'Add-CBreezeFilterPageBuilderParameter', 
               'Add-CBreezeFilterPageBuilderVariable', 
               'Add-CBreezeFilterQueryElement', 'Add-CBreezeFunction', 
               'Add-CBreezeGuidParameter', 'Add-CBreezeGuidTableField', 
               'Add-CBreezeGuidVariable', 'Add-CBreezeInStreamParameter', 
               'Add-CBreezeInStreamVariable', 'Add-CBreezeIntegerParameter', 
               'Add-CBreezeIntegerTableField', 'Add-CBreezeIntegerVariable', 
               'Add-CBreezeIntegrationEventPublisherFunction', 
               'Add-CBreezeKeyRefParameter', 'Add-CBreezeKeyRefVariable', 
               'Add-CBreezeMediaSetTableField', 'Add-CBreezeMediaTableField', 
               'Add-CBreezeMenuSuite', 'Add-CBreezeNotificationParameter', 
               'Add-CBreezeNotificationScopeParameter', 
               'Add-CBreezeNotificationScopeVariable', 
               'Add-CBreezeNotificationVariable', 'Add-CBreezeObjectTypeParameter', 
               'Add-CBreezeObjectTypeVariable', 'Add-CBreezeOcxParameter', 
               'Add-CBreezeOcxVariable', 'Add-CBreezeOptionParameter', 
               'Add-CBreezeOptionTableField', 'Add-CBreezeOptionVariable', 
               'Add-CBreezeOutStreamParameter', 'Add-CBreezeOutStreamVariable', 
               'Add-CBreezePage', 'Add-CBreezePageAction', 
               'Add-CBreezePageActionContainer', 'Add-CBreezePageActionGroup', 
               'Add-CBreezePageActionSeparator', 'Add-CBreezePageControl', 
               'Add-CBreezePageControlContainer', 'Add-CBreezePageControlGroup', 
               'Add-CBreezePageControlPart', 'Add-CBreezePageParameter', 
               'Add-CBreezePageVariable', 'Add-CBreezeQuery', 'Add-CBreezeQueryLink', 
               'Add-CBreezeQueryOrderBy', 'Add-CBreezeQueryParameter', 
               'Add-CBreezeQueryVariable', 'Add-CBreezeRecordIDParameter', 
               'Add-CBreezeRecordIDTableField', 'Add-CBreezeRecordIDVariable', 
               'Add-CBreezeRecordParameter', 'Add-CBreezeRecordRefParameter', 
               'Add-CBreezeRecordRefVariable', 'Add-CBreezeRecordVariable', 
               'Add-CBreezeReport', 'Add-CBreezeReportFormatParameter', 
               'Add-CBreezeReportFormatVariable', 'Add-CBreezeReportLabel', 
               'Add-CBreezeReportParameter', 'Add-CBreezeReportVariable', 
               'Add-CBreezeRunObjectLink', 'Add-CBreezeTable', 
               'Add-CBreezeTableConnectionTypeParameter', 
               'Add-CBreezeTableConnectionTypeVariable', 
               'Add-CBreezeTableFieldGroup', 'Add-CBreezeTableFilterTableField', 
               'Add-CBreezeTableKey', 'Add-CBreezeTableRelation', 
               'Add-CBreezeTableRelationCondition', 
               'Add-CBreezeTableRelationFilter', 'Add-CBreezeTestFunction', 
               'Add-CBreezeTestPageParameter', 'Add-CBreezeTestPageVariable', 
               'Add-CBreezeTestPermissionsParameter', 
               'Add-CBreezeTestPermissionsVariable', 
               'Add-CBreezeTestRequestPageParameter', 'Add-CBreezeTextConstant', 
               'Add-CBreezeTextEncodingParameter', 
               'Add-CBreezeTextEncodingVariable', 'Add-CBreezeTextParameter', 
               'Add-CBreezeTextTableField', 'Add-CBreezeTextVariable', 
               'Add-CBreezeTimeParameter', 'Add-CBreezeTimeTableField', 
               'Add-CBreezeTimeVariable', 'Add-CBreezeTransactionTypeParameter', 
               'Add-CBreezeTransactionTypeVariable', 'Add-CBreezeUpgradeFunction', 
               'Add-CBreezeVariantParameter', 'Add-CBreezeVariantVariable', 
               'Add-CBreezeXmlPort', 'Add-CBreezeXmlPortLink', 
               'Add-CBreezeXmlPortParameter', 'Add-CBreezeXmlPortVariable', 
               'Application', 'AutomationParameter', 'AutomationVariable', 
               'BigIntegerField', 'BigIntegerParameter', 'BigIntegerVariable', 
               'BigTextParameter', 'BigTextVariable', 'BinaryField', 'BinaryParameter', 
               'BinaryVariable', 'BlobField', 'BooleanField', 'BooleanParameter', 
               'BooleanVariable', 'BusinessEvent', 'ByteParameter', 'ByteVariable', 
               'CalcFormula', 'CalcFormulaFilter', 'CharParameter', 'CharVariable', 
               'ClientTypeParameter', 'ClientTypeVariable', 'CodeField', 'CodeLine', 
               'CodeParameter', 'Codeunit', 'CodeunitParameter', 'CodeunitVariable', 
               'CodeVariable', 'Compile', 'ContainerControl', 'DateField', 
               'DateFormulaField', 'DateFormulaParameter', 'DateFormulaVariable', 
               'DateParameter', 'DateTimeField', 'DateTimeParameter', 
               'DateTimeVariable', 'DateVariable', 'DecimalField', 'DecimalParameter', 
               'DecimalVariable', 'DefaultLayoutParameter', 'DefaultLayoutVariable', 
               'DefaultRange', 'DeltaNode', 'DialogParameter', 'DialogVariable', 
               'DotNetParameter', 'DotNetVariable', 'DurationField', 
               'DurationParameter', 'DurationVariable', 'Event', 'EventSubscriber', 
               'ExecutionModeParameter', 'ExecutionModeVariable', 'Export', 
               'FieldAttribute', 'FieldControl', 'FieldElement', 'FieldGroup', 
               'FieldRefParameter', 'FieldRefVariable', 'FileParameter', 
               'FileVariable', 'FilterField', 'FilterPageBuilderParameter', 
               'FilterPageBuilderVariable', 'GroupControl', 'GroupNode', 'GuidField', 
               'GuidParameter', 'GuidVariable', 'Import', 'InStreamParameter', 
               'InStreamVariable', 'IntegerField', 'IntegerParameter', 
               'IntegerVariable', 'IntegrationEvent', 'Invoke', 'ItemNode', 'Key', 
               'KeyRefParameter', 'KeyRefVariable', 'MediaField', 'MediaSetField', 
               'MenuNode', 'MenuSuite', 'MLValue', 'NotificationParameter', 
               'NotificationScopeParameter', 'NotificationScopeVariable', 
               'NotificationVariable', 'ObjectTypeParameter', 'ObjectTypeVariable', 
               'OcxParameter', 'OcxVariable', 'OptionField', 'OptionParameter', 
               'OptionVariable', 'OrderBy', 'OutStreamParameter', 'OutStreamVariable', 
               'Page', 'PageParameter', 'PageVariable', 'PartControl', 'Permission', 
               'Procedure', 'Query', 'QueryColumn', 'QueryDataItem', 'QueryFilter', 
               'QueryLink', 'QueryParameter', 'QueryVariable', 'RecordIDField', 
               'RecordIDParameter', 'RecordIDVariable', 'RecordParameter', 
               'RecordRefParameter', 'RecordRefVariable', 'RecordVariable', 'Report', 
               'ReportColumn', 'ReportDataItem', 'ReportFormatParameter', 
               'ReportFormatVariable', 'ReportLabel', 'ReportParameter', 
               'ReportVariable', 'RootNode', 'RunObjectLink', 'Table', 'TableAttribute', 
               'TableConnectionTypeParameter', 'TableConnectionTypeVariable', 
               'TableElement', 'TableFilter', 'TableRelation', 
               'TableRelationCondition', 'TableRelationFilter', 'TestFunction', 
               'TestPageParameter', 'TestPageVariable', 'TestPermissionsParameter', 
               'TestPermissionsVariable', 'TestRequestPageParameter', 
               'TextAttribute', 'TextConstant', 'TextElement', 'TextEncodingParameter', 
               'TextEncodingVariable', 'TextField', 'TextParameter', 'TextVariable', 
               'TimeField', 'TimeParameter', 'TimeVariable', 
               'TransactionTypeParameter', 'TransactionTypeVariable', 
               'UpgradeFunction', 'VariantParameter', 'VariantVariable', 'XmlPort', 
               'XmlPortLink', 'XmlPortParameter', 'XmlPortVariable'

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        LicenseUri = 'https://github.com/jhoek/UncommonSense.CBreeze/blob/master/LICENSE.md'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/jhoek/UncommonSense.CBreeze'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable
    
 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

