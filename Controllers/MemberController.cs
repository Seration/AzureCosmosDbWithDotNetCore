using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureCosmosDbExample.Data;
using AzureCosmosDbExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureCosmosDbExample.Controllers
{
    public class MemberController : Controller
    {
        private readonly IMemberRepository<Member> _repo;

        public MemberController(IMemberRepository<Member> repo)
        {
            _repo = repo;
        }

        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            var members = await _repo.GetMembersAsync();
            return View(members);
        }

        [ActionName("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Member member)
        {
            if (ModelState.IsValid)
            {
                await _repo.CreateMemberAsync(member);
                return RedirectToAction("Index");
            }

            return View(member);
        }


        [ActionName("Edit")]
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
                return BadRequest();

            Member member = await _repo.GetMemberAsync(id);

            if (member == null)
                return NotFound();

            return View(member);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Member member)
        {
            if (ModelState.IsValid)
            {
                await _repo.UpdateMemberAsync(member.Id, member);
                return RedirectToAction("Index");
            }

            return View(member);
        }

        [ActionName("Delete")]
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
                return BadRequest();

            Member member = await _repo.GetMemberAsync(id);

            if (member == null)
                return NotFound();

            return View(member);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAction(string id)
        {
            await _repo.DeleteMember(id);
            return RedirectToAction("Index");
        }
    }
}