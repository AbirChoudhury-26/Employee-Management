﻿using EmployeeManagementLibrary.Models;
using EmployeeManagementLibrary.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLibrary.Handlers
{
	
	public class GetEmployeeByIdHandler:IRequestHandler<GetEmployeeByIdQuery,EmployeeModel>
	{
		private readonly IMediator _mediator;

		public GetEmployeeByIdHandler(IMediator mediator)
		{
			_mediator = mediator;
		}
		 public	async Task<EmployeeModel>Handle(GetEmployeeByIdQuery request,CancellationToken cancellationToken)
		{
			var employee = await _mediator.Send(new GetEmployeeListQuery());
			var searchEmp = employee.FirstOrDefault(x => x.Id == request.Id);
			return searchEmp;
		}
	}
}
