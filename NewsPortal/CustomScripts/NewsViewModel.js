function NewsDTO(id, name, content, createTime, editTime, authorId) {
	self.Id = ko.observable(id);
	self.Name = ko.observable(name);
	self.Content = ko.observable(content);
	self.CreateTime = ko.observable(createTime);
	self.EditTime = ko.observable(editTime);
	self.AuthorName = ko.observable();

	self.GetAuthorName = function(authorId) {
		$.ajax({
			type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "/Home/GetUser",
            data: {id: authorId}
		}).success(function(data) {
			self.AuthorName = data.user.Name;
		}).error(function() {
			console.log("error get author name");
		})
	}
	self.GetAuthorName(authorId);
}

var NewsViewModel = function() {
	var self = this;
	var news = [];

	self.News = ko.observableArray(news);
	self.GetNews = function() {
		$.ajax({
			type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "/Home/GetNews"
		}).success(function(data) {
			console.log(data);
			// for(var i = 0; i < data.news.length; i++) {
			// 	news.push(new NewsDTO(data.news[i].))
			// }
		}).error(function(){
			console.log("error get news");
		})
	}

	self.GetNews();
}