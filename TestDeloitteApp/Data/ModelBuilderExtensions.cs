
using TestDeloitteApp.Models;
using Microsoft.EntityFrameworkCore;
namespace TestDeloitteApp.Data;
public static class ModelBuilderExtensions
{
    public static ModelBuilder Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CaseDiary>().HasData(
        new CaseDiary
        {
            Id = 1,
            CaseId = "2323",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        }, 
        new CaseDiary
        {
            Id = 2,
            CaseId = "2323",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        },
        new CaseDiary
        {
            Id = 3,
            CaseId = "2323",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        },
        new CaseDiary
        {
            Id = 4,
            CaseId = "2323",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        },
        new CaseDiary
        {
            Id = 5,
            CaseId = "2323",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        },
        new CaseDiary
        {
            Id = 6,
            CaseId = "111",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        },
        new CaseDiary
        {
            Id = 7,
            CaseId = "111",
            StartDate = DateTime.Now,
            DueDate = DateTime.Now,
            Function = "aaaaa",
            SubFunction = "bbbb",
            Open = "Yes",
            Prim = "No",
            Mother = "asassa",
            Father = "asassa",
            MotherViolence = true,
            FatherViolence = false,

        });


        return modelBuilder;
    }
}