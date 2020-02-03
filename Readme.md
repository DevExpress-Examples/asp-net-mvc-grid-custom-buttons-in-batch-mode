<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/T150411/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/T150411/Controllers/HomeController.vb))
* [Model.cs](./CS/T150411/Models/Model.cs) (VB: [Model.vb](./VB/T150411/Models/Model.vb))
* [_GridViewPartial.cshtml](./CS/T150411/Views/Home/_GridViewPartial.cshtml) (VB: [_GridViewPartial.vbhtml](./VB/T150411/Views/Home/_GridViewPartial.vbhtml))
* [Index.cshtml](./CS/T150411/Views/Home/Index.cshtml) (VB: [Index.vbhtml](./VB/T150411/Views/Home/Index.vbhtml))
<!-- default file list end -->

# GridView - Batch Editing - How to display save and cancel buttons only after editing

<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t150411/)**
<!-- run online end -->

**UPDATED:**

Starting with v18.2, if a grid contains modified data, it displays a confirmation message before a grid performs a postback or a callback. The [KeepChangesOnCallbacks](https://docs.devexpress.com/AspNet/DevExpress.Web.GridViewBatchEditSettings.KeepChangesOnCallbacks) property specifies whether the grid supports callbacks and allows you to use the 'Preview changes' button to preview and modify inserted, deleted and edited rows before you click 'Save changes'.

This example demonstrates how you can hide both  *Save changes* and *Cancel changes* buttons, and to display them only when modifications have been made to a cell or row by an end-user.
  
**See Also:**  
[GridView - Batch Editing - How to use external buttons to update data and enable them only when a row/cell has been changed](https://www.devexpress.com/Support/Center/p/T150395)  

**ASP.NET WebForms example:**  
[ASPxGridView - Batch Editing - How to show save and cancel buttons only when any row/cell has been changed](https://www.devexpress.com/Support/Center/p/T114462)


