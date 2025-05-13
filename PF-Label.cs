@using System.Collections.Generic;

@inherits Resto.Front.PrintTemplates.Cheques.Razor.TemplateBase<Resto.Front.PrintTemplates.Cheques.Razor.TemplateModels.IPriceTicket>

<doc>
    <np />
  <f1>
    <center>
      @Model.Product.Name
    </center>
  </f1>
  <left><f0>@string.Format("Время приготовления {1}", Resources.PrintTimeColon, FormatFullDateTime(Model.CommonInfo.CurrentTime))</f0></left>

  <left><wrap><f0>Срок хранения: @Model.Product.ExpirationPeriod.Hours ч. @Model.Product.ExpirationPeriod.Minutes мин.</f0></wrap></left> 




  @if (Model.Product.ExpirationPeriod.Ticks > 0)
  {
    <left><f0>
      @string.Join(" ", Resources.BarcodeExpiration, FormatLongDateTime(Model.CommonInfo.CurrentTime + Model.Product.ExpirationPeriod)) 
    </f0></left>
  }
  else
  {
    <left><f0>Время окончания не задано</f0></left>
  }

  <left><f0>@string.Format("Кто приготовил: {0}", Model.CommonInfo.CurrentUser.Name)</f0></left>
  
  <np />
  <np />
</doc>