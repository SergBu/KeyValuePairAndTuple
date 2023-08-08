// See https://aka.ms/new-console-template for more information

using KeyValuePairAndTuple;
using static System.Runtime.InteropServices.JavaScript.JSType;

var restriction = new Restriction();
var updates = new List<KeyValuePair<Restriction, int>>();

updates.Add(new KeyValuePair<Restriction, int>(restriction, restriction.VehiclesCount));

foreach (var update in updates.OrderBy(p => p.Value))
{
    //using (var service = _serviceFactory.UpdateTerminalRestrictionService(_context,
    //    _setting,
    //    _balanceByCrops,
    //    _balanceByMembers,
    //    _reserveHelper))
    //{
    //    var request = new UpdateTerminalRestrictionRequest()
    //    {
    //        TerminalId = _request.TerminalId,
    //        Date = date,
    //        Restriction = update.Key,
    //        MemberId = _request.MemberId,
    //        MemberType = _request.MemberType
    //    };

    //    var result = await service.Execute(request);

    //    await _context.SaveChangesAsync();

    //    _restrictionBeforeAndAfterUpdateTupleList.Add((result.TerminalRestrictionBeforeUpdate, result.TerminalRestrictionAfterUpdate));


    //    _balanceByCrops = await _terminalRestrictionRepository.CheckBalance(_context, _setting, _request.TerminalId, date, _balanceByCrops);
    //    _balanceByMembers = await _terminalRestrictionRepository.CheckBalance(_context, _setting, _request.TerminalId, date, _balanceByMembers);
    //}
}

var restrictionBeforeAndAfterUpdateTupleList = new List<(Restriction, Restriction)>();

restrictionBeforeAndAfterUpdateTupleList.Add((restriction, restriction));

foreach (var restrictionBeforeAndAfterUpdate in restrictionBeforeAndAfterUpdateTupleList)
{
    if (restrictionBeforeAndAfterUpdate.Item1 != null && restrictionBeforeAndAfterUpdate.Item2 != null)
    {
        if (restrictionBeforeAndAfterUpdate.Item1.MaxVehiclesCount != restrictionBeforeAndAfterUpdate.Item2.MaxVehiclesCount)
        {
            //if (restrictionBeforeAndAfterUpdate.Item1.Shared)
            //{
            //    await _terminalRestricitonNotificationService.SendNotificationAboutBoilerRestricitonsUpdateAsync(restrictionBeforeAndAfterUpdate.Item2);
            //}
            //else
            //{
            //    await _apiClient.CallRestrictionNotificationAsync<CallRestrictionRequestBase>(new CallRestrictionRequestBase
            //    {
            //        EventType = EventTypeCode.RestrictionCreatedByTerminal,
            //        Crops = restrictionBeforeAndAfterUpdate.Item2.Crops.Select(x => x.CropId).ToArray(),
            //        Date = restrictionBeforeAndAfterUpdate.Item2.Date,
            //        Receivers = new Receivers
            //        {
            //            CargoOwners = restrictionBeforeAndAfterUpdate.Item2.Members.Where(x => x.MemberRole == MemberRole.RestrictionOwner).Select(x => x.MemberId).ToArray()
            //        },
            //        TerminalId = restrictionBeforeAndAfterUpdate.Item2.TerminalId,
            //        VehicleCount = restrictionBeforeAndAfterUpdate.Item2.VehiclesCount
            //    });
            //}

            //UpdateTerminalRestrictionShortRequest requestForHandler = _handlerRequestService.PrepareUpdateTerminalRestrictionShortRequestForHandler(restrictionBeforeAndAfterUpdate.Item1, restrictionBeforeAndAfterUpdate.Item2, _request.MemberId, _request.MemberType, _request.TerminalId);

            //_updateTerminalRestrictionTerminalManualOperationHandler.EnqueueWorkItem(requestForHandler);
        }
    }
}

//var cropsFromBoilerWhichCargoOwnerHaveAccess = cargoOwnerHaveAccessToBoiler
//    .Select(x => new Tuple<int, int>((x.Crops.FirstOrDefault()?.CropId ?? 0),
//    (x.Crops.FirstOrDefault()?.CropWithParameterCombinationToTerminalRestrictionGroupCrops.FirstOrDefault()?.TerminalAdditionalParameterCombinationId ?? 0))).Distinct().ToList();

//var sharedRestrictionJoinedCurrentMemberBoiler = boilerByGate.Value.Where(x => cropsFromBoilerWhichCargoOwnerHaveAccess
//.Any(y => y.Item1 == (x.Crops.FirstOrDefault()?.CropId ?? 0)
//&& y.Item2 == (x.Crops.First().CropWithParameterCombinationToTerminalRestrictionGroupCrops.FirstOrDefault()?.TerminalAdditionalParameterCombinationId ?? 0))).ToList();