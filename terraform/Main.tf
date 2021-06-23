variable services {

    default = {

        "codeTA" = "codeTA-app-service"

        "nameTA" = "nameTA-app-service"

        "mergeTA"= "mergeTA-app-service"

        "FrontEndTA"= "TAFrontEnd-app-service"

    }

}

provider "azurerm" { 

    features {} 

    }



resource "azurerm_resource_group" "rg" {

  name     = "TA-resources"

  location = "uksouth"

}



resource "azurerm_app_service_plan" "master" {

  name                = "TA-appserviceplan"

  location            = azurerm_resource_group.rg.location

  kind                = "Windows"

  reserved            = false



  resource_group_name = azurerm_resource_group.rg.name

  sku {

    tier = "Basic"

    size = "B1"

  }

}



resource "azurerm_app_service" "master" {



    for_each = var.services

    name = each.value

    location = azurerm_resource_group.rg.location

    resource_group_name = azurerm_resource_group.rg.name

    app_service_plan_id = azurerm_app_service_plan.master.id



    site_config{

        dotnet_framework_version ="v5.0"

    }



    app_settings = {

     "AppSettings__codeServiceURL": "https://codeTA-app-service.azurewebsites.net/"

     "AppSettings__nameServiceURL": "https://nameTA-app-service.azurewebsites.net/"

     "AppSettings__mergedServiceURL" : "https://mergeTA-app-service.azurewebsites.net/"

    }

}



