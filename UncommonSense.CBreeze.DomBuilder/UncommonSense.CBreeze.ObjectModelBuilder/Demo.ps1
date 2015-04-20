﻿function Add-Item
{
    param
    (
        [Parameter(Mandatory=$true,ValueFromPipeLine=$true)]
        [UncommonSense.CBreeze.ObjectModelBuilder.ObjectModel]$ObjectModel,

        [Parameter(Mandatory=$true)]
        [string]$Name,

        [string]$BaseTypeName,

        [bool]$Abstract,

        [Switch]$CreateContainer
    )

    $Item = New-Object UncommonSense.CBreeze.ObjectModelBuilder.Item -ArgumentList $Name
    $Item.BaseTypeName = $BaseTypeName
    $Item.Abstract = $Abstract 
    $ObjectModel.Elements.Add($Item) | Out-Null

    if ($CreateContainer)
    {
        $ObjectModel | Add-Container -ItemTypeName $Item.Name | Out-Null
    }

    $Item
}

function Add-Container
{
    param
    (
        [Parameter(Mandatory=$true,ValueFromPipeLine=$true)]
        [UncommonSense.CBreeze.ObjectModelBuilder.ObjectModel]$ObjectModel,

        [Parameter(Mandatory=$true)]
        [string]$ItemTypeName,

        [string]$Name
    )

    if (-not $Name)
    {
        $Name = "$($ItemTypeName)s"
    }

    $Container = New-Object UncommonSense.CBreeze.ObjectModelBuilder.Container -ArgumentList $ItemTypeName, $Name
    $ObjectModel.Elements.Add($Container)
}

function Add-Attribute
{
    param
    (
        [Parameter(Mandatory=$true,ValueFromPipeLine=$true)]
        [UncommonSense.CBreeze.ObjectModelBuilder.Item]$Item,

        [Parameter(Mandatory=$true)]
        [string]$TypeName,

        [string]$Name
    )

    if (-not $Name)
    {
        $Name= $TypeName
    }

    $Attribute = New-Object UncommonSense.CBreeze.ObjectModelBuilder.Attribute -ArgumentList $TypeName, $Name
    $Item.Attributes.Add($Attribute) | Out-Null
    $Item
}

$LibraryPath = Join-Path $PSScriptRoot Bin/Debug/UncommonSense.CBreeze.ObjectModelBuilder.dll
Add-Type -Path $LibraryPath

$ErrorActionPreference = 'Stop'

$Namespace = "UncommonSense.CBreeze.ObjectModelBuilder.Demo"
$ObjectModel = New-Object UncommonSense.CBreeze.ObjectModelBuilder.ObjectModel -ArgumentList $Namespace

$ObjectModel | Add-Properties -Name TableProperties | Add-Property 

$ObjectModel | `
    Add-Item `
        -Name Object 
        -Abstract $true | `
            Add-Attribute `
                -Name ID 
                -TypeName int | 
            Add-Attribute `
                -Name Name 
                -TypeName string 

$ObjectModel | Add-Item -Name Table -BaseTypeName Object -CreateContainer 
$ObjectModel | Add-Item -Name Page -BaseTypeName Object -CreateContainer
$ObjectModel | Add-Item -Name Report -BaseTypeName Object -CreateContainer

$ObjectModel | Add-Item -Name Application | Add-Attribute -TypeName Tables | Add-Attribute -TypeName Pages |Add-Attribute -TypeName Reports