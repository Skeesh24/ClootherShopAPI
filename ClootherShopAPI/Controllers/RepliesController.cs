﻿using ClootherShopAPI.DAL.Context;
using ClootherShopAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClootherShopAPI.Controllers;

public class RepliesController : Controller
{
    private DataContext? context;

    public RepliesController(DataContext context)
    {
        this.context = context;
    }

    [HttpPost("/reviews")]
    public IActionResult ReplyAdd()
    {
        return Ok();
    }

    /// <summary>
    /// return 5 latest replies
    /// </summary>
    /// <returns></returns>
    [HttpGet("Replies/{pageId}")]
    public IActionResult Get5LateReplies([FromRoute] int pageId)
    {
        var res = Array.Empty<ReplyEntity>();

        // move any logic to model
        if (context is not null)
            res = context.Replies.OrderBy(x => x.ReplyDateTime)
                .Take(5)
                .ToArray();

        return Json(res);
    }
}
