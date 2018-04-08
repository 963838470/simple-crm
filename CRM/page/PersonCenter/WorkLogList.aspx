﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WorkLogList.aspx.cs" Inherits="CRM.page.PersonCenter.WorkLogList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>工作日志</title>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../../css/common.css" rel="stylesheet" />
    <script src="../../Scripts/jquery-3.0.0.js"></script>
    <script src="../../Scripts/umd/popper.js"></script>
    <script src="../../Scripts/bootstrap.js"></script>
</head>
<body>
    <div class="container-fluid">
        <div class="card">
            <div class="card-header">
                工作日志
            </div>
            <div class="card-body">
                <form class="form-inline mb-2">
                    <div class="form-group">
                        <label for="staticEmail2">标题：</label>
                        <input type="text" class="form-control" id="staticEmail2" />
                    </div>
                    <div class="form-group mx-sm-3">
                        <label for="inputPassword2">日期：</label>
                        <input type="text" class="form-control" id="inputPassword2" />
                    </div>
                    <button type="button" class="btn btn-primary ml-auto">查询</button>
                </form>
                <table class="table table-striped table-bordered table-hover">
                    <thead>
                        <tr>
                            <th scope="col">标题</th>
                            <th scope="col">日期</th>
                            <th scope="col">操作</th>
                        </tr>
                    </thead>
                    <tbody>
                        <% foreach (var item in logs)
                            { %>
                        <tr>
                            <th scope="row"><%=item.Title %></th>
                            <td><%=item.CreateTime %></td>
                            <td>
                                <button type="button" class="btn btn-outline-success btn-xs">编辑</button>
                                <button type="button" class="btn btn-outline-danger btn-xs">删除</button>
                            </td>
                        </tr>
                        <% } %>
                    </tbody>
                </table>
            </div>
            <div class="card-footer text-muted">
            </div>
        </div>
    </div>
</body>
</html>