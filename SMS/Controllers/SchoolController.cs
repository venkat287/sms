// Controllers/SchoolController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS.Models;
using SMS;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[Route("api/[Controller]")]
[ApiController]
public class SchoolController : ControllerBase
{
    private readonly SchoolDbContext _context;

    public SchoolController(SchoolDbContext context)
    {
        _context = context;
    }


    /// <summary>
    /// Gets a list of school inspections.
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<InspectionInfo>>> GetSchoolInspection()
    {
        return await _context.InspectionInfos.ToListAsync();
    }

    /// <summary>
    /// Post the inspection detail for school
    /// </summary>
    [HttpPost]
    public async Task<ActionResult<School>> PostInspection(InspectionInfo inspectionInfo)
    {
        _context.InspectionInfos.Add(inspectionInfo);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(PostInspection), inspectionInfo);
    }
}
