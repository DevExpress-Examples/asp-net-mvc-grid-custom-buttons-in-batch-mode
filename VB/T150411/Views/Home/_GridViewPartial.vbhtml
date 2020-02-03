@Code
    Dim grid = Html.DevExpress().GridView(Sub(settings)
                                              settings.Name = "GridView"
                                              settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "GridViewPartial"}
                                              settings.SettingsEditing.BatchUpdateRouteValues = New With {Key .Controller = "Home", Key .Action = "BatchUpdatePartial"}
                                              settings.SettingsEditing.Mode = GridViewEditingMode.Batch

                                              settings.CommandColumn.Visible = True
                                              settings.CommandColumn.ShowNewButtonInHeader = True
                                              Dim customButton As New GridViewCommandColumnCustomButton()
                                              customButton.Text = "Delete"
                                              customButton.ID = "deleteButton"
                                              settings.CommandColumn.CustomButtons.Add(customButton)

                                              settings.KeyFieldName = "ID"

                                              settings.Columns.Add("C1")
                                              settings.Columns.Add(Sub(column)
                                                                       column.FieldName = "C2"
                                                                       column.ColumnType = MVCxGridViewColumnType.SpinEdit
                                                                   End Sub)
                                              settings.Columns.Add("C3")
                                              settings.Columns.Add(Sub(column)
                                                                       column.FieldName = "C4"
                                                                       column.ColumnType = MVCxGridViewColumnType.CheckBox
                                                                   End Sub)
                                              settings.Columns.Add(Sub(column)
                                                                       column.FieldName = "C5"
                                                                       column.ColumnType = MVCxGridViewColumnType.DateEdit
                                                                   End Sub)
                                              settings.CellEditorInitialize = Sub(s, e)
                                                                                  Dim editor As ASPxEdit = CType(e.Editor, ASPxEdit)
                                                                                  editor.ValidationSettings.Display = Display.Dynamic
                                                                              End Sub

                                              settings.Styles.StatusBar.CssClass = "StatusBarWithButtons"
                                              settings.SetStatusBarTemplateContent(Sub(c)
                                                                                       ViewContext.Writer.Write("<div style='text-align: right'>")
                                                                                       Html.DevExpress().Button(Sub(button)
                                                                                                                    button.Name = "btnPrevChanges"
                                                                                                                    button.RenderMode = ButtonRenderMode.Outline
                                                                                                                    button.Text = "Preview changes"
                                                                                                                    button.UseSubmitBehavior = False
                                                                                                                    button.ClientSideEvents.Click = "OnPreviewChangesClick"
                                                                                                                End Sub).Render()
                                                                                       Html.DevExpress().Button(Sub(button)
                                                                                                                    button.Name = "btnSave"
                                                                                                                    button.RenderMode = ButtonRenderMode.Outline
                                                                                                                    button.Text = "Save changes"
                                                                                                                    button.UseSubmitBehavior = False
                                                                                                                    button.ClientSideEvents.Click = "function(s, e){ GridView.UpdateEdit(); }"
                                                                                                                End Sub).Render()
                                                                                       Html.DevExpress().Button(Sub(button)
                                                                                                                    button.Name = "btnCancel"
                                                                                                                    button.RenderMode = ButtonRenderMode.Outline
                                                                                                                    button.Text = "Cancel changes"
                                                                                                                    button.UseSubmitBehavior = False
                                                                                                                    button.ClientSideEvents.Click = "function(s, e){ GridView.CancelEdit(); SetButtonsVisibility(GridView); }"
                                                                                                                End Sub).Render()
                                                                                       ViewContext.Writer.Write("</div>")
                                                                                   End Sub)
                                              settings.ClientSideEvents.Init = "function(s, e){ SetButtonsVisibility(s); }"
                                              settings.ClientSideEvents.EndCallback = "function(s, e){ SetButtonsVisibility(s) }"
                                              settings.ClientSideEvents.BatchEditEndEditing = "OnBatchEditEndEditing"
                                              settings.ClientSideEvents.CustomButtonClick = "OnCustomButtonClick"
                                          End Sub)
End Code
@grid.Bind(Model).GetHtml()
