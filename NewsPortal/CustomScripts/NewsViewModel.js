function NewsDTO(id, name, content, createTime, editTime) {
	var self = this;
	
	self.Id = ko.observable(id);
	self.Name = ko.observable(name);
	self.Content = ko.observable(content);
	self.CreateTime = ko.observable(createTime);
	self.EditTime = ko.observable(editTime);
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
			for(var i = 0; i < data.news.length; i++) {
				news.push(new NewsDTO(data.news[i].Id, data.news[i].Name, data.news[i].Content, data.news[i].CreateTime, data.news[i].EditTime));
			}
			self.News(news);

		}).error(function(){
			console.log("error get news");
		})
	}

	self.GetNews();
}