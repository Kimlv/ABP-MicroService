﻿using Business.BaseData.OrganizationManagement.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Business.BaseData.OrganizationManagement
{
    public interface IOrganizationAppService : IApplicationService
    {
        Task<ListResultDto<OrganizationDto>> GetAll(GetOrganizationInputDto input);

        Task<ListResultDto<OrganizationDto>> GetAllWithParents(GetOrganizationInputDto input);

        Task<PagedResultDto<OrganizationDto>> GetAllList(GetOrganizationInputDto input);

        Task<OrganizationDto> Get(Guid id);

        Task<OrganizationDto> Create(CreateOrUpdateOrganizationDto input);

        Task<OrganizationDto> Update(Guid id, CreateOrUpdateOrganizationDto input);

        Task Delete(List<Guid> ids);
    }
}
