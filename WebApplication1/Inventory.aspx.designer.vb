﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated. 
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Partial Public Class Inventory

    '''<summary>
    '''frmInventory control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents frmInventory As Global.System.Web.UI.HtmlControls.HtmlForm

    '''<summary>
    '''sqldsProduct control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents sqldsProduct As Global.System.Web.UI.WebControls.SqlDataSource

    '''<summary>
    '''sqldsVendor control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents sqldsVendor As Global.System.Web.UI.WebControls.SqlDataSource

    '''<summary>
    '''rblProductChoice control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents rblProductChoice As Global.System.Web.UI.WebControls.RadioButtonList

    '''<summary>
    '''rblVendorChoice control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents rblVendorChoice As Global.System.Web.UI.WebControls.RadioButtonList

    '''<summary>
    '''lblExistingProduct control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblExistingProduct As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''lblExistingVendor control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblExistingVendor As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''lblExistingProductInside control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblExistingProductInside As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlExistingProduct control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlExistingProduct As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''lblExistingVendorInside control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblExistingVendorInside As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''ddlExistingVendor control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlExistingVendor As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''lblProductID control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblProductID As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''lblVendorID control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblVendorID As Global.System.Web.UI.WebControls.Label

    '''<summary>
    '''txtProductDescription control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtProductDescription As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtVendorName control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtVendorName As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtProductPrice control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtProductPrice As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtVendorAddress control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtVendorAddress As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtProductQuantity control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtProductQuantity As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtVendorContactName control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtVendorContactName As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''ddlLinkedVendor control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents ddlLinkedVendor As Global.System.Web.UI.WebControls.DropDownList

    '''<summary>
    '''txtVendorContactPhone control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtVendorContactPhone As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''txtVendorAccountNumber control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents txtVendorAccountNumber As Global.System.Web.UI.WebControls.TextBox

    '''<summary>
    '''btnProductApply control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnProductApply As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''btnVendorApply control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents btnVendorApply As Global.System.Web.UI.WebControls.Button

    '''<summary>
    '''lblInventoryStatus control.
    '''</summary>
    '''<remarks>
    '''Auto-generated field.
    '''To modify move field declaration from designer file to code-behind file.
    '''</remarks>
    Protected WithEvents lblInventoryStatus As Global.System.Web.UI.WebControls.Label
End Class
