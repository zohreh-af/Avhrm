using Avhrm.Infrastructure.Client;

namespace Avhrm.UI.Shared.Pages.Vacation;

public partial class VacationRequest
{
    public bool IsLoading = false;
    public bool IsEditMode = false;

    public InsertVacationRequestCommand Command = new();

    public List<GetVacationRequestsByUserIdDto> AllVacationRequests = new();
    [Inject] public ApiHandler Api { get; set; }

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;

        AllVacationRequests = (await Api.SendJsonAsync<GetVacationRequestsByUserIdVm>(HttpMethod.Get
            , "WorkChallenge/GetAll")).Value.Data;

        IsLoading = false;
    }

    public async Task OnValidSubmit(EditContext context)
    {

    }

    public async Task OnInvalidSubmit(EditContext context)
    {

    }
    public async Task CloseEditMode()
    {

    }


}