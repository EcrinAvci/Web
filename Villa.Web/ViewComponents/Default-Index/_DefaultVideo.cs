﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.VideoDtos;

namespace Villa.Web.ViewComponents.Default_Index
{
    public class _DefaultVideo : ViewComponent
    {
        private readonly IVideoService _videoService;

        public _DefaultVideo(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _videoService.TGetListAsync();
            var videoList = _mapper.Map<List<ResultVideoDto>>(values);
            return View(videoList);
        }
    }
}
