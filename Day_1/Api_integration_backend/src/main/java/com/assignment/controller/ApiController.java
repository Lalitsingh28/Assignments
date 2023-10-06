package com.assignment.controller;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.client.RestTemplate;

import com.assignment.dto.Request;
import com.assignment.dto.Responce;

@RestController
@RequestMapping("/content")
public class ApiController {
	
	@Value("${model}")
	private String model; 
	
	@Value("${url}")
	private String url;
	
	@Autowired
	private RestTemplate restTemplate;
	
	@GetMapping("/word")
	public String generateContent(@RequestParam String keyword){
		
		String prompt = "Generate the content on the word :";
		Request request = new Request(model,prompt+keyword);
		Responce responce = restTemplate.postForObject(url, request,Responce.class);
		return responce.getChoices().get(0).getMessage().getMassage();
	
		
	}

}
