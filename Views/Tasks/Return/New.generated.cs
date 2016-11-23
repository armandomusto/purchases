﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Tasks\Return\New.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.NPoco;
    using Frapid.WebsiteBuilder;
    using MixERP.Purchases;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Return/New.cshtml")]
    public partial class _Views_Tasks_Return_New_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Tasks_Return_New_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Tasks\Return\New.cshtml"
  
    ViewBag.Title = "Bank Accounts";
    Layout = ViewBag.PurchaseLayoutPath;
    var meta = AppUsers.GetCurrent();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/Areas/MixERP.Purchases/Styles/purchase.css\"");

WriteLiteral("></link>\r\n\r\n<div");

WriteLiteral(" class=\"ui attached inverted pos purchase segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui active inverted dimmer\"");

WriteLiteral(" id=\"POSDimmer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui large text loader\"");

WriteLiteral(">Doing something ...</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"ui grid\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"eleven wide column\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"status head\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"left\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"office info\"");

WriteLiteral(" title=\"Current Branch Office\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 21 "..\..\Views\Tasks\Return\New.cshtml"
                   Write(meta.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"user info\"");

WriteLiteral(" title=\"You\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 24 "..\..\Views\Tasks\Return\New.cshtml"
                   Write(meta.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"area info\"");

WriteLiteral(" title=\"Current Area\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 27 "..\..\Views\Tasks\Return\New.cshtml"
                   Write(meta.OfficeCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"office info\"");

WriteLiteral(" title=\"Office Name\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 30 "..\..\Views\Tasks\Return\New.cshtml"
                   Write(meta.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inline blocks\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" class=\"ui search inverted fluid dropdown\"");

WriteLiteral(" id=\"PriceTypeSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div");

WriteLiteral(" class=\"category list\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"cat filter\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                    Clear\r\n                    <i");

WriteLiteral(" class=\"delete icon\"");

WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"search panel\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" placeholder=\"Search ...\"");

WriteLiteral(" />\r\n\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"item list\"");

WriteLiteral(" id=\"POSItemList\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"five wide column\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"tender info\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" id=\"SummaryItems\"");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"amount item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Amount</div>\r\n                        <div");

WriteLiteral(" class=\"money\"");

WriteLiteral(">\r\n                            <span></span>\r\n                        </div>\r\n   " +
"                 </div>\r\n                    <div");

WriteLiteral(" class=\"store item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Store</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"StoreSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"one summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"supplier item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Supplier</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"SupplierSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"value date item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Value Date</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" id=\"ValueDateInputDate\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"book date item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Book Date</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" id=\"BookDateInputDate\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"cost center item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Cost Center</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"CostCenterSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"           <div");

WriteLiteral(" class=\"shipping company item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Shipper</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"ShipperSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"reference number item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Ref#</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"memo item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Memo</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"StatementReferenceInputText\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"ui one column padded grid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" id=\"CheckoutButton\"");

WriteLiteral(" class=\"ui green icon big button\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"cart icon\"");

WriteLiteral("></i>\r\n                            CHECKOUT\r\n                        </button>\r\n " +
"                       <button");

WriteLiteral(" id=\"ClearScreenButton\"");

WriteLiteral(" class=\"ui red icon big button\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"delete icon\"");

WriteLiteral("></i>\r\n                            CLS\r\n                        </button>\r\n      " +
"              </div>\r\n                </div>\r\n            </div>\r\n            <d" +
"iv");

WriteLiteral(" id=\"PurchaseItems\"");

WriteLiteral(" class=\"purchase items\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(\"#Pu" +
"rchaseItems .item\")\r\n        .on(\"contextmenu\",\r\n            function (e) {\r\n   " +
"             e.preventDefault();\r\n                var el = $(this);\r\n           " +
"     var defaultMenu = el.find(\".info.block, .number.block\");\r\n                v" +
"ar contextMenu = el.find(\".context.menu\");\r\n\r\n                defaultMenu.toggle" +
"();\r\n                contextMenu.toggle();\r\n            });\r\n</script>\r\n\r\n<scrip" +
"t>\r\n    var itemTemplate = `<div class=\"item\" id=\"pos-{ItemId}\" data-cost-price=" +
"\"{CostPrice}\" data-photo=\"{Photo}\" data-unit-id=\"{UnitId}\" data-valid-units=\"{Va" +
"lidUnits}\" data-brand=\"{BrandName}\" data-item-group=\"{ItemGroupName}\" data-item-" +
"name=\"{ItemName}\" data-item-code=\"{ItemCode}\" data-item-id=\"{ItemId}\" data-price" +
"=\"{Price}\">\r\n\t<div class=\"photo block\">\r\n\t\t<img src=\"{Photo}\">\r\n\t</div>\r\n\t<div c" +
"lass=\"info block\">\r\n\t\t<div class=\"header\">{ItemName}</div>\r\n\t\t<div class=\"price " +
"info\">\r\n\t\t\t<span class=\"rate\">{CostPrice}</span>\r\n\t\t\t<span>&nbsp; x&nbsp; </span" +
">\r\n\t\t\t<span class=\"quantity\">1</span>\r\n\t\t\t<span>&nbsp; =&nbsp; </span>\r\n\t\t\t<span" +
" class=\"amount\"></span>\r\n\t\t</div>\r\n\t\t<div class=\"discount info\" style=\"display:n" +
"one;\">\r\n\t\t\t<span>Less&nbsp; </span>\r\n\t\t\t<span class=\"discount rate\"></span>\r\n\t\t\t" +
"<span>&nbsp; =&nbsp; </span>\r\n\t\t\t<span class=\"discounted amount\"></span>\r\n\t\t</di" +
"v>\r\n\t\t<div>\r\n\t\t\t<select class=\"unit inverted\" data-item-id=\"{ItemId}\">\r\n\t\t\t</sel" +
"ect>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"number block\">\r\n\t\t<input type=\"text\" class" +
"=\"price\" title=\"Edit Price\" value=\"{CostPrice}\">\r\n\t\t<input type=\"text\" class=\"qu" +
"antity\" title=\"Enter Quantity\" value=\"1\">\r\n\t\t<input type=\"text\" class=\"discount\"" +
" title=\"Enter Discount\" value=\"\">\r\n\t\t<button class=\"ui red fluid button\" onclick" +
"=\"removeItem(this);\" style=\"display:none;\">Delete</button>\r\n\t</div>\r\n</div>`\r\n</" +
"script>\r\n\r\n<script>\r\n    var products = [];\r\n    var metaUnits = [];\r\n\r\n    func" +
"tion fetchUnits() {\r\n        function request() {\r\n            var url = \"/api/f" +
"orms/inventory/units/all\";\r\n            return window.getAjaxRequest(url);\r\n    " +
"    };\r\n\r\n        var ajax = request();\r\n\r\n        ajax.success(function (respon" +
"se) {\r\n            window.metaUnits = response;\r\n        });\r\n    };\r\n\r\n    func" +
"tion fetchProducts() {\r\n        function request() {\r\n            var url = \"/da" +
"shboard/purchase/tasks/items\";\r\n            return window.getAjaxRequest(url);\r\n" +
"        };\r\n\r\n        var ajax = request();\r\n\r\n        ajax.success(function (re" +
"sponse) {\r\n            window.products = response;\r\n            $(document).trig" +
"ger(\"itemFetched\");\r\n        });\r\n    };\r\n\r\n    $(\".search.panel input\").keyup(f" +
"unction () {\r\n        var el = $(this);\r\n        var term = el.val();\r\n\r\n       " +
" var categoryEl = $(\".category.list .selected.category\");\r\n        var category " +
"= \"\";\r\n\r\n        if (categoryEl.length) {\r\n            category = categoryEl.tex" +
"t();\r\n        };\r\n\r\n        displayProducts(category, term);\r\n\r\n        initiali" +
"zeClickAndAction();\r\n    });\r\n\r\n    $(\".search.panel input\").keydown(function (e" +
") {\r\n        if (e.keyCode === 13) {\r\n            var item = $(\".item.list .item" +
":first\");\r\n\r\n            if (item.length) {\r\n                item.trigger(\"click" +
"\");\r\n            };\r\n        };\r\n    });\r\n\r\n    window.fetchUnits();\r\n    window" +
".fetchProducts();\r\n\r\n    setTimeout(function () {\r\n        window.fetchProducts(" +
");\r\n    }, 120000);\r\n\r\n    function removeItem(el) {\r\n        var confirmed = co" +
"nfirm(\"Are you sure?\");\r\n\r\n        if (!confirmed) {\r\n            return;\r\n     " +
"   };\r\n\r\n        el = $(el);\r\n        var container = el.parent().parent();\r\n   " +
"     container.remove();\r\n        window.updateTotal();\r\n    };\r\n\r\n    $(documen" +
"t).on(\"itemFetched\", function () {\r\n        $(\"#POSDimmer\").removeClass(\"active\"" +
");\r\n        displayProducts();\r\n        displayCategories();\r\n        initialize" +
"ClickAndAction();\r\n    });\r\n\r\n\r\n    function initializeClickAndAction() {\r\n     " +
"   $(\"#POSItemList .item\").unbind(\"click\").bind(\"click\", function () {\r\n        " +
"    var el = $(this);\r\n            var costPrice = el.attr(\"data-cost-price\");\r\n" +
"            var photo = el.attr(\"data-photo\");\r\n\r\n            var barCode = el.a" +
"ttr(\"data-barcode\");\r\n            var brand = el.attr(\"data-brand\");\r\n          " +
"  var unitId = el.attr(\"data-unit-id\");\r\n            var validUnits = el.attr(\"d" +
"ata-valid-units\");\r\n            var itemGroup = el.attr(\"data-item-group\");\r\n   " +
"         var itemName = el.attr(\"data-item-name\");\r\n            var itemCode = e" +
"l.attr(\"data-item-code\");\r\n            var itemId = el.attr(\"data-item-id\");\r\n  " +
"          var price = parseFloat(costPrice || 0);\r\n\r\n            if (!price) {\r\n" +
"                alert(\"Cannot add item because the price is zero.\");\r\n          " +
"      return;\r\n            };\r\n\r\n\r\n\r\n            var targetEl = $(\"#PurchaseItem" +
"s\");\r\n            var selector = \"pos-\" + itemId;\r\n            var existingEl = " +
"$(\"#\" + selector);\r\n\r\n            if (existingEl.length) {\r\n                var " +
"existingQuantitySpan = existingEl.find(\"span.quantity\");\r\n                var ex" +
"istingQuantityInput = existingEl.find(\"input.quantity\");\r\n\r\n                var " +
"quantity = parseInt(existingQuantitySpan.text() || 0);\r\n                quantity" +
"++;\r\n\r\n                existingQuantitySpan.text(quantity);\r\n                exi" +
"stingQuantityInput.val(quantity).trigger(\"keyup\");\r\n\r\n                window.upd" +
"ateTotal();\r\n                return;\r\n            };\r\n\r\n            var template" +
" = itemTemplate;\r\n\r\n            template = template.replace(/{ItemId}/g, itemId)" +
";\r\n            template = template.replace(/{CostPrice}/g, costPrice);\r\n        " +
"    template = template.replace(/{Photo}/g, photo);\r\n            template = temp" +
"late.replace(/{BarCode}/g, barCode);\r\n            template = template.replace(/{" +
"BrandName}/g, brand);\r\n            template = template.replace(/{ItemGroupName}/" +
"g, itemGroup);\r\n            template = template.replace(/{ItemName}/g, itemName)" +
";\r\n            template = template.replace(/{ItemCode}/g, itemCode);\r\n          " +
"  template = template.replace(/{Price}/g, price);\r\n            template = templa" +
"te.replace(/{UnitId}/g, unitId);\r\n            template = template.replace(/{Vali" +
"dUnits}/g, validUnits);\r\n\r\n            var item = $(template);\r\n            var " +
"quantityInput = item.find(\"input.quantity\");\r\n            var priceInput = item." +
"find(\"input.price\");\r\n            var discountInput = item.find(\"input.discount\"" +
");\r\n            var unitSelect = item.find(\"select.unit\");\r\n\r\n            functi" +
"on loadUnits(el, defaultUnitId, validUnits) {\r\n                el.html(\"\");\r\n\r\n " +
"               var units = window.Enumerable.From(window.metaUnits)\r\n           " +
"         .Where(function (x) {\r\n                        return validUnits.indexO" +
"f(x.unit_id.toString()) > -1;\r\n                    }).ToArray();\r\n\r\n            " +
"    $.each(units, function () {\r\n                    var unit = this;\r\n\r\n       " +
"             var option = $(\"<option/ >\");\r\n                    option.attr(\"val" +
"ue\", unit.unit_id);\r\n                    option.html(unit.unit_name);\r\n\r\n       " +
"             if (defaultUnitId === unit.unit_id) {\r\n                        opti" +
"on.attr(\"selected\", \"\");\r\n                    };\r\n\r\n                    option.a" +
"ppendTo(el);\r\n                });\r\n\r\n            };\r\n\r\n            loadUnits(uni" +
"tSelect, unitId, validUnits.split(\',\'));\r\n\r\n            function updateItemTotal" +
"(el) {\r\n                var quantityEl = el.find(\"input.quantity\");\r\n           " +
"     var discountEl = el.find(\"input.discount\");\r\n\r\n                var quantity" +
" = parseInt(quantityEl.val() || 0);\r\n                var discountRate = parseFlo" +
"at(discountEl.val().replace(\"%\", \"\"));\r\n                var price = parseFloat(e" +
"l.find(\"input.price\").val());\r\n                //var price = parseFloat(el.attr(" +
"\"data-price\") || 0);\r\n\r\n                var amount = (price * quantity).toFixed(" +
"2);\r\n                var discountedAmount = ((price * quantity) * ((100 - discou" +
"ntRate) / 100)).toFixed(2);\r\n\r\n                el.find(\"span.rate:not(.discount)" +
"\").html(price);\r\n                el.find(\"span.quantity\").html(quantity);\r\n     " +
"           el.find(\"span.amount\").html(amount);\r\n                el.find(\"span.d" +
"iscount.rate\").html(\"\");\r\n                el.find(\"span.discounted.amount\").html" +
"(\"\");\r\n\r\n                if (discountRate) {\r\n                    el.find(\".disc" +
"ount.info\").show();\r\n                    el.find(\"span.discount.rate\").html(disc" +
"ountEl.val().replace(\"%\", \"\") + \"%\");\r\n                    el.find(\"span.discoun" +
"ted.amount\").html(discountedAmount);\r\n                } else {\r\n                " +
"    el.find(\".discount.info\").hide();\r\n                }\r\n\r\n                wind" +
"ow.updateTotal();\r\n\r\n            };\r\n\r\n            quantityInput.on(\"keyup\", fun" +
"ction () {\r\n                var el = $(this);\r\n                var parentInfo = " +
"el.parent().parent();\r\n                updateItemTotal(parentInfo);\r\n           " +
" });\r\n\r\n            discountInput.on(\"keyup\", function () {\r\n                var" +
" el = $(this);\r\n\r\n                var rate = parseFloat(el.val());\r\n            " +
"    if (rate > 100) {\r\n                    el.val(\"100\");\r\n                    r" +
"eturn;\r\n                };\r\n\r\n                var parentInfo = el.parent().paren" +
"t();\r\n                updateItemTotal(parentInfo);\r\n            });\r\n\r\n         " +
"   priceInput.on(\"keyup\", function () {\r\n                var el = $(this);\r\n    " +
"            var parentInfo = el.parent().parent();\r\n                updateItemTo" +
"tal(parentInfo);\r\n            });\r\n\r\n            discountInput.on(\"blur\", functi" +
"on () {\r\n                var el = $(this);\r\n                var value = el.val()" +
";\r\n\r\n                if (!value) {\r\n                    return;\r\n               " +
" };\r\n\r\n                if (value.substr(value.length - 1) === \"%\") {\r\n          " +
"          return;\r\n                };\r\n\r\n                el.val(el.val() + \"%\");" +
"\r\n                var parentInfo = el.parent().parent();\r\n                update" +
"ItemTotal(parentInfo);\r\n            });\r\n\r\n            function getPrice(el) {\r\n" +
"                function request(itemId, supplierId, unitId) {\r\n                " +
"    var url = \"/dashboard/purchase/tasks/cost-price/{itemId}/{supplierId}/{unitI" +
"d}\";\r\n                    url = url.replace(\"{itemId}\", itemId);\r\n              " +
"      url = url.replace(\"{supplierId}\", supplierId);\r\n                    url = " +
"url.replace(\"{unitId}\", unitId);\r\n\r\n                    return window.getAjaxReq" +
"uest(url);\r\n                };\r\n\r\n                var itemId = el.attr(\"data-ite" +
"m-id\");\r\n                var supplierId = parseInt($(\"#SupplierSelect\").val() ||" +
" 0);\r\n                var unitId = el.val();\r\n\r\n                $(\".pos.purchase" +
".segment\").addClass(\"loading\");\r\n                var ajax = request(itemId, supp" +
"lierId, unitId);\r\n\r\n                ajax.success(function (response) {\r\n        " +
"            $(\".pos.purchase.segment\").removeClass(\"loading\");\r\n                " +
"    var priceInput = el.parent().parent().parent().find(\"input.price\");\r\n       " +
"             priceInput.val(response).trigger(\"keyup\");\r\n                });\r\n\r\n" +
"                ajax.fail(function (xr) {\r\n                    $(\".pos.purchase." +
"segment\").removeClass(\"loading\");\r\n                    console.log(window.getAja" +
"xErrorMessage(xhr));\r\n                });\r\n            };\r\n\r\n            unitSel" +
"ect.on(\"change\", function () {\r\n                getPrice($(this));\r\n            " +
"});\r\n\r\n            item.on(\"contextmenu\", function (e) {\r\n                e.prev" +
"entDefault();\r\n                var el = $(this);\r\n                var inputEl = " +
"el.find(\".number.block input\");\r\n                var buttonEl = el.find(\".number" +
".block button\");\r\n\r\n                inputEl.toggle();\r\n                buttonEl." +
"toggle();\r\n            });\r\n\r\n            item.appendTo(targetEl);\r\n            " +
"quantityInput.trigger(\"keyup\");\r\n            window.updateTotal();\r\n        });\r" +
"\n    };\r\n\r\n    $(\"#SummaryItems div.discount .money input, \" +\r\n        \"#Receip" +
"tSummary div.tender .money input\").keyup(function () {\r\n            window.updat" +
"eTotal();\r\n        });\r\n\r\n    function updateTotal() {\r\n        var candidates =" +
" $(\"#PurchaseItems div.item\");\r\n        var amountEl = $(\"#SummaryItems div.amou" +
"nt .money\");\r\n\r\n        var totalPrice = 0;\r\n        //var totalQuantity = 0;\r\n\r" +
"\n        $.each(candidates, function () {\r\n            var el = $(this);\r\n      " +
"      var quantityEl = el.find(\"input.quantity\");\r\n            var discountEl = " +
"el.find(\"input.discount\");\r\n\r\n            var quantity = parseInt(quantityEl.val" +
"() || 0);\r\n            var discountRate = parseFloat(discountEl.val().replace(\"%" +
"\", \"\"));\r\n            var price = parseFloat(el.find(\"input.price\").val());\r\n   " +
"         //var price = parseFloat(el.attr(\"data-price\") || 0);\r\n\r\n            va" +
"r amount = price * quantity;\r\n            var discountedAmount = amount * ((100 " +
"- discountRate) / 100);\r\n\r\n            totalPrice += (discountedAmount || amount" +
");\r\n            //totalQuantity += quantity;\r\n        });\r\n\r\n        totalPrice " +
"= parseFloat(totalPrice.toFixed(2));\r\n\r\n        amountEl.html(totalPrice);\r\n    " +
"};\r\n\r\n    function displayCategories() {\r\n        var categories = window.Enumer" +
"able.From(products).Distinct(function (x) { return x.ItemGroupName }).Select(fun" +
"ction (x) { return x.ItemGroupName }).ToArray();\r\n        var targetEl = $(\".cat" +
".filter\");\r\n        $(\".category.list\").find(\".category\").remove();\r\n\r\n        t" +
"argetEl.unbind(\"click\").bind(\"click\", function () {\r\n            displayProducts" +
"();\r\n            $(\".category\").removeClass(\"selected\");\r\n            targetEl.h" +
"ide();\r\n            initializeClickAndAction();\r\n        });\r\n\r\n        $.each(c" +
"ategories, function () {\r\n            var category = $(\"<div class=\'category\' />" +
"\");\r\n            category.html(this);\r\n\r\n            category.unbind(\"click\").bi" +
"nd(\"click\", function () {\r\n                $(\".search.panel input\").val(\"\");\r\n  " +
"              var el = $(this);\r\n                var name = el.text();\r\n\r\n      " +
"          if (name) {\r\n                    displayProducts(name);\r\n             " +
"       $(\".category\").removeClass(\"selected\");\r\n                    el.addClass(" +
"\"selected\");\r\n\r\n                    targetEl.show();\r\n                } else {\r\n" +
"                    targetEl.hide();\r\n                };\r\n\r\n                init" +
"ializeClickAndAction();\r\n            });\r\n\r\n            targetEl.before(category" +
");\r\n        });\r\n    };\r\n\r\n    function displayProducts(category, searchQuery) {" +
"\r\n        var target = $(\"#POSItemList\");\r\n\r\n        var groupItems;\r\n\r\n        " +
"if (!category && !searchQuery) {\r\n            groupItems = products;\r\n        } " +
"else {\r\n            if (category && searchQuery) {\r\n                groupItems =" +
" window.Enumerable\r\n                    .From(products)\r\n                    .Wh" +
"ere(function (x) {\r\n                        return x.ItemGroupName.toLowerCase()" +
" === category.toString().toLowerCase()\r\n                            && x.ItemNam" +
"e.toLowerCase().indexOf(searchQuery.toLowerCase()) > -1;\r\n                    })" +
".ToArray();\r\n            } else if (!category && searchQuery) {\r\n               " +
" groupItems = window.Enumerable\r\n                    .From(products)\r\n          " +
"          .Where(function (x) {\r\n                        return x.ItemName.toLow" +
"erCase().indexOf(searchQuery.toLowerCase()) > -1;\r\n                    }).ToArra" +
"y();\r\n            } else {\r\n                groupItems = window.Enumerable\r\n    " +
"                .From(products)\r\n                    .Where(function (x) {\r\n    " +
"                    return x.ItemGroupName.toLowerCase() === category.toString()" +
".toLowerCase();\r\n                    }).ToArray();\r\n            };\r\n        };\r\n" +
"\r\n        groupItems = window.Enumerable.From(groupItems).OrderBy(function (x) {" +
" return x.ItemId }).ToArray();\r\n\r\n        target.html(\"\").hide();\r\n\r\n        $.e" +
"ach(groupItems, function () {\r\n            var product = this;\r\n\r\n            va" +
"r item = $(\"<div class=\'item\' />\");\r\n            item.attr(\"data-item-id\", produ" +
"ct.ItemId);\r\n            item.attr(\"data-item-code\", product.ItemCode);\r\n       " +
"     item.attr(\"data-item-name\", product.ItemName);\r\n            item.attr(\"data" +
"-item-group\", product.ItemGroupName);\r\n            item.attr(\"data-brand\", produ" +
"ct.BrandName);\r\n            item.attr(\"data-unit-id\", product.UnitId);\r\n        " +
"    item.attr(\"data-valid-units\", product.ValidUnits);\r\n            item.attr(\"d" +
"ata-barcode\", product.Barcode);\r\n            item.attr(\"data-photo\", product.Pho" +
"to);\r\n            item.attr(\"data-cost-price\", product.CostPrice);\r\n\r\n          " +
"  if (product.HotItem) {\r\n                item.addClass(\"hot\");\r\n            };\r" +
"\n\r\n            var info = $(\"<div class=\'info\' />\");\r\n\r\n            var price = " +
"$(\"<div class=\'price\' />\");\r\n            price.html(product.CostPrice);\r\n\r\n     " +
"       price.appendTo(info);\r\n\r\n\r\n            var photo = $(\"<div class=\'photo\' " +
"/>\");\r\n            var img = $(\"<img />\");\r\n            img.attr(\"src\", product." +
"Photo + \"?Height=200&Width=200\");\r\n\r\n            img.appendTo(photo);\r\n         " +
"   photo.appendTo(info);\r\n\r\n            var name = $(\"<div class=\'name\' />\");\r\n " +
"           name.html(product.ItemName);\r\n\r\n            name.appendTo(info);\r\n\r\n " +
"           info.appendTo(item);\r\n            item.appendTo(target);\r\n        });" +
"\r\n\r\n        if (searchQuery) {\r\n            target.show();\r\n            return;\r" +
"\n        };\r\n\r\n        target.fadeIn(500);\r\n    };\r\n\r\n</script>\r\n<script>\r\n    $" +
"(\"#CheckoutButton\").unbind(\"click\").bind(\"click\", function () {\r\n\r\n        funct" +
"ion request(model) {\r\n            var url = \"/dashboard/purchase/tasks/return/ne" +
"w\";\r\n            var data = JSON.stringify(model);\r\n            return window.ge" +
"tAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n        function getModel() {\r\n " +
"           function getDetails() {\r\n                var items = $(\"#PurchaseItem" +
"s .item\");\r\n                var model = [];\r\n\r\n                $.each(items, fun" +
"ction () {\r\n                    var el = $(this);\r\n                    var itemI" +
"d = parseInt(el.attr(\"data-item-id\"));\r\n                    var quantity = parse" +
"Int(el.find(\"input.quantity\").val());\r\n                    var unitId = parseInt" +
"(el.find(\"select.unit\").val());\r\n                    var price = parseFloat(el.f" +
"ind(\"input.price\").val() || 0);\r\n                    var discount = parseFloat(e" +
"l.find(\"input.discount\").val() || 0);\r\n                    model.push({\r\n       " +
"                 StoreId: $(\"#StoreSelect\").val(),\r\n                        Item" +
"Id: itemId,\r\n                        Quantity: quantity,\r\n                      " +
"  UnitId: unitId,\r\n                        Price: price,\r\n                      " +
"  Discount: discount\r\n                    });\r\n                });\r\n\r\n          " +
"      return model;\r\n            };\r\n\r\n            var transactionMasterId = par" +
"seInt(window.getQueryStringByName(\"TransactionMasterId\") || 0);\r\n            var" +
" valueDate = $(\"#ValueDateInputDate\").datepicker(\"getDate\");\r\n            var bo" +
"okDate = $(\"#BookDateInputDate\").datepicker(\"getDate\");\r\n            var costCen" +
"terId = $(\"#CostCenterSelect\").val();\r\n            var referenceNumber = $(\"#Ref" +
"erenceNumberInputText\").val();\r\n            var statementReference = $(\"#Stateme" +
"ntReferenceInputText\").val();\r\n            var supplierId = $(\"#SupplierSelect\")" +
".val();\r\n            var priceTypeId = $(\"#PriceTypeSelect\").val();\r\n           " +
" var shipperId = $(\"#ShipperSelect\").val();\r\n            var storeId = $(\"#Store" +
"Select\").val();\r\n            var details = getDetails();\r\n\r\n            return {" +
"\r\n                TransactionMasterId: transactionMasterId,\r\n                Val" +
"ueDate: valueDate,\r\n                BookDate: bookDate,\r\n                CostCen" +
"terId: costCenterId,\r\n                ReferenceNumber: referenceNumber,\r\n       " +
"         StatementReference: statementReference,\r\n                SupplierId: su" +
"pplierId,\r\n                PriceTypeId: priceTypeId,\r\n                ShipperId:" +
" shipperId,\r\n                StoreId: storeId,\r\n                Details: details" +
"\r\n            };\r\n        };\r\n\r\n        var model = getModel();\r\n\r\n        if (!" +
"model.TransactionMasterId) {\r\n            alert(\"Access is denied.\");\r\n         " +
"   document.location = \"/dashboard/purchase/tasks/entry\";\r\n            return;\r\n" +
"        };\r\n\r\n        if (!model.Details.length) {\r\n            window.displayMe" +
"ssage(\"Please select an item.\");\r\n            return;\r\n        };\r\n\r\n        var" +
" confirmed = confirm(\"Are you sure\");\r\n\r\n        if (!confirmed) {\r\n            " +
"return;\r\n        };\r\n\r\n\r\n        $(\"#CheckoutButton\").addClass(\"loading\");\r\n\r\n  " +
"      var ajax = request(model);\r\n\r\n        ajax.success(function (response) {\r\n" +
"            var id = response;\r\n            document.location = \"/dashboard/purc" +
"hase/tasks/return/checklist/\" + id;\r\n        });\r\n\r\n        ajax.fail(function (" +
"xhr) {\r\n            $(\"#CheckoutButton\").removeClass(\"loading\");\r\n            al" +
"ert(JSON.stringify(xhr));\r\n        });\r\n    });\r\n</script>\r\n\r\n<script>\r\n    $(\"#" +
"ClearScreenButton\")\r\n        .unbind(\"click\")\r\n        .bind(\"click\",\r\n         " +
"   function () {\r\n                clearScreen();\r\n            });\r\n\r\n    functio" +
"n clearScreen() {\r\n        $(\"#PurchaseItems\").html(\"\");\r\n        window.updateT" +
"otal();\r\n    };\r\n</script>\r\n\r\n<script>\r\n    function displayFieldBinder(el, url)" +
" {\r\n        function request() {\r\n            return window.getAjaxRequest(url);" +
"\r\n        };\r\n\r\n        var ajax = request();\r\n\r\n        ajax.success(function (" +
"response) {\r\n            var options = \"\";\r\n\r\n            $.each(response, funct" +
"ion () {\r\n                var option = \"<option value=\'{key}\'>{value}</option>\";" +
"\r\n                option = option.replace(\"{key}\", this.Key);\r\n                o" +
"ption = option.replace(\"{value}\", this.Value);\r\n\r\n                options += opt" +
"ion;\r\n            });\r\n\r\n            el.html(options);\r\n        });\r\n    };\r\n\r\n " +
"   function loadStores() {\r\n        displayFieldBinder($(\"#StoreSelect\"), \"/api/" +
"forms/inventory/stores/display-fields\");\r\n    };\r\n\r\n    function loadShippers() " +
"{\r\n        displayFieldBinder($(\"#ShipperSelect\"), \"/api/forms/inventory/shipper" +
"s/display-fields\");\r\n    };\r\n\r\n    function loadCostCenters() {\r\n        display" +
"FieldBinder($(\"#CostCenterSelect\"), \"/api/forms/finance/cost-centers/display-fie" +
"lds\");\r\n    };\r\n\r\n    function loadPriceTypes() {\r\n        displayFieldBinder($(" +
"\"#PriceTypeSelect\"), \"/api/forms/purchase/price-types/display-fields\");\r\n    };\r" +
"\n\r\n    function loadSuppliers() {\r\n        displayFieldBinder($(\"#SupplierSelect" +
"\"), \"/api/forms/inventory/suppliers/display-fields\");\r\n    };\r\n\r\n    loadStores(" +
");\r\n    loadPriceTypes();\r\n    loadSuppliers();\r\n    loadCostCenters();\r\n    loa" +
"dShippers();\r\n</script>\r\n\r\n<script>\r\n    setTimeout(function () {\r\n        $(\".d" +
"ecimal\").number(true, window.currencyDecimalPlaces, \".\", \"\");\r\n    }, 100);\r\n\r\n\r" +
"\n    window.overridePath = \"/dashboard/purchase/tasks/return\";\r\n</script>");

        }
    }
}
#pragma warning restore 1591
