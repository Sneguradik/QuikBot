using GrpcWorker.Services;
using Microsoft.AspNetCore.Mvc;
using GetClassSecuritiesResult =  Qlua.Rpc.GetClassSecurities.Result;
using GetClassSecuritiesArgs =  Qlua.Rpc.GetClassSecurities.Args;

namespace GrpcWorker.Controllers;

[Route("classes")]
[ApiController]
public class ClassesController(IClassService classService) : ControllerBase
{
    [HttpGet("get_classes")]
    public string GetClasses() => classService.GetClassesList().ClassesList;

    [HttpPost("get_class_securities")]
    public GetClassSecuritiesResult GetClassSecurities([FromBody] GetClassSecuritiesArgs args) =>
        classService.GetClassSecurities(args.ClassCode);
}